/*
 * create_view.c
 *
 *  Created on: Jun 10, 2015
 *      Author: seongyong
 */

#include "view/create_view.h"
#include <time.h>
#include <locations.h>


schedule_info_s *schedule;

typedef struct create_view_data{
	appdata_s *ad;
	Evas_Object *conform,
		*entry,
		*entry_title,
		*entry_comment,
		*entry_start_date,
		*entry_finish_date,
		*layout,
		*navi,
		*scroller,
		*grid,
		*bg,
		*button,
		*image,
		*label,
		*map,
		*popup;
	Elm_Map_Overlay *ovl;
	Elm_Object_Item *navi_it;

	double longitude;
	double latitude;
	char start_time[20];
	char finish_time[20];
	char tag[20];
} cv_data;

int cnt = 0;

static Elm_Entry_Filter_Limit_Size title_size =
{
   .max_char_count = 20,
   .max_byte_count = 0
};

static Elm_Entry_Filter_Limit_Size comment_size =
{
   .max_char_count = 20,
   .max_byte_count = 0
};

static void clicked_cancel_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	appdata_s *ad = data;



	create_calendar_view(ad);
}

static void
map_ok_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	cv_data *ad = data;

	Evas_Object *popup = ad->popup;
	evas_object_del(popup);

}

static location_service_state_e service_state;
static void __state_changed_cb(location_service_state_e state, void *user_data)
{
   service_state = state;
}
static void clicked_map_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	cv_data *ad = data;
	Evas_Object *map = ad->map;

	elm_map_region_get(map,&ad->longitude,&ad->latitude);

	char buff[100];
	sprintf(buff,"map changed lat = %lf, lon = %lf", ad->latitude, ad->longitude);

	dlog_print(DLOG_DEBUG, LOG_TAG, buff);

	Elm_Map_Overlay *ov = elm_map_overlay_add(ad->map, ad->longitude, ad->latitude);;
	Evas_Object *icon;
	icon = elm_icon_add(ad->map);
	elm_icon_standard_set(icon,"home");
	elm_map_overlay_icon_set(ov,icon);
}
static void clicked_location_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	cv_data *ad = data;
	Evas_Object *win = ad->ad->win;

	Evas_Object
		*popup,
		*btn,
		*layout,
		*map;

	location_manager_h manager;
	int ret = location_manager_create(LOCATIONS_METHOD_HYBRID,&manager);
	ret = location_manager_set_service_state_changed_cb(manager, __state_changed_cb,manager);
	ret = location_manager_start(manager);

	double altitude, latitude, longitude, climb, direction, speed;
	double horizontal, vertical;
	location_accuracy_level_e level;
	time_t timestamp;
	ret = location_manager_get_last_location(manager, &altitude, &ad->latitude, &ad->longitude,
	                                         &climb, &direction, &speed, &level, &horizontal, &vertical, &timestamp);

	ret = location_manager_get_location(manager, &altitude, &ad->latitude, &ad->longitude,
	                                          &climb, &direction, &speed, &level,
	                                          &horizontal, &vertical, &timestamp);


	char buff[100];
	sprintf(buff,"lat = %lf, lon = %lf", ad->latitude, ad->longitude);

	dlog_print(DLOG_DEBUG, LOG_TAG, buff);

	ad->popup = elm_popup_add(win);
	elm_popup_align_set(ad->popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	eext_object_event_callback_add(ad->popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
	elm_object_part_text_set(ad->popup, "title,text", "LOCATION SET");
	evas_object_size_hint_weight_set(ad->popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	layout = elm_layout_add(ad->popup);
	elm_layout_file_set(layout, ELM_EDJ, "popup_checkview_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(layout);

	ad->map = elm_map_add(layout);
	elm_map_zoom_mode_set(ad->map,ELM_MAP_ZOOM_MODE_MANUAL);
	elm_map_zoom_set(ad->map,15);
	elm_map_region_bring_in(ad->map,ad->longitude,ad->latitude);
	evas_object_smart_callback_add(ad->map,"clicked,double",clicked_map_cb,ad);
	evas_object_size_hint_align_set(ad->map, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(ad->map, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_part_content_set(layout, "elm.swallow.content", ad->map);

	Evas_Object *icon;
	Elm_Map_Overlay *forest_class = elm_map_overlay_class_add(ad->map);

	elm_map_overlay_displayed_zoom_min_set(forest_class,8);

	icon = elm_icon_add(ad->map);
	elm_icon_standard_set(icon,"home");
	elm_map_overlay_icon_set(forest_class,icon);

	Elm_Map_Overlay *ovl = ad->ovl;
	ovl = elm_map_overlay_add(ad->map, ad->longitude, ad->latitude);

//	elm_map_overlay_region_get(ovl, &longitude, &latitude);
//
//
//
//	sprintf(buff,"new lat = %lf, lon = %lf", latitude, longitude);
//
//	dlog_print(DLOG_DEBUG, LOG_TAG, buff);


//	scroller = elm_image_add(layout);
//	elm_image_file_set(scroller, ICON_DIR"/gps_icon.png", NULL);
//	elm_image_aspect_fixed_set(scroller, EINA_TRUE);
//	elm_image_resizable_set(scroller, EINA_FALSE, EINA_FALSE);
//	elm_object_part_content_set(layout, "elm.swallow.content", scroller);

//	scroller = elm_scroller_add(layout);
//	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
//	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
//
//	grid = elm_grid_add(scroller);
//	evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	evas_object_size_hint_align_set(grid, EVAS_HINT_FILL, EVAS_HINT_FILL);
//
//	map = elm_map_add(grid);
//	elm_map_zoom_mode_set(map,ELM_MAP_ZOOM_MODE_MANUAL);
//	elm_map_zoom_set(map,15);
//	elm_map_region_bring_in(map,127.04,37.28);
//	elm_grid_pack(grid,map,0,0,100,100);
//	evas_object_show(map);
//
//	elm_object_content_set(scroller, grid);

//	elm_object_part_content_set(layout,"elm.swallow.content",scroller);
	elm_object_content_set(ad->popup,layout);

//	btn = elm_button_add(ad->popup);
//	elm_object_style_set(btn, "popup");
//	elm_object_text_set(btn, "Cancel");
//	elm_object_part_content_set(ad->popup, "button1", btn);
//	evas_object_smart_callback_add(btn, "clicked", popup_btn_clicked_cb, ad->popup);

	btn = elm_button_add(ad->popup);
	elm_object_style_set(btn, "popup");
	elm_object_text_set(btn, "OK");
	elm_object_part_content_set(ad->popup, "button1", btn);
	evas_object_smart_callback_add(btn, "clicked", map_ok_btn_clicked_cb, ad);

	evas_object_show(ad->popup);
}

static void
ctxpopup_dismissed_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *ctxpopup = data;

	evas_object_del(ctxpopup);
	ctxpopup = NULL;
}

static void
ctxpopup_item_select_cb(void *data, Evas_Object *obj, void *event_info)
{
	const char *label = elm_object_item_text_get((Elm_Object_Item *) event_info);
	if (label) fprintf(stderr, "text(%s) is clicked\n", label);

	Evas_Object *icon = elm_object_item_content_get((Elm_Object_Item *) event_info);
	if (icon) fprintf(stderr, "icon is clicked\n");
}

static void
move_dropdown(Evas_Object *ctxpopup, Evas_Object *btn)
{
	Evas_Coord x, y, w , h;
	evas_object_geometry_get(btn, &x, &y, &w, &h);
	evas_object_move(ctxpopup, x + (w / 2), y + h);
}


static void clicked_tag_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	cv_data *ad = data;
	Evas_Object *nf = ad->navi;

	Evas_Object *ctxpopup;

	ctxpopup = elm_ctxpopup_add(nf);
	elm_object_style_set(ctxpopup, "dropdown/label");
	eext_object_event_callback_add(ctxpopup, EEXT_CALLBACK_BACK, eext_ctxpopup_back_cb, NULL);
	evas_object_smart_callback_add(ctxpopup,"dismissed", ctxpopup_dismissed_cb, ctxpopup);

	getTags();

	elm_ctxpopup_item_append(ctxpopup, "Message", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Email", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Facebook", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Bluetooth", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Flickr", NULL, ctxpopup_item_select_cb, NULL);

	elm_ctxpopup_direction_priority_set(ctxpopup, ELM_CTXPOPUP_DIRECTION_DOWN, ELM_CTXPOPUP_DIRECTION_UNKNOWN, ELM_CTXPOPUP_DIRECTION_UNKNOWN, ELM_CTXPOPUP_DIRECTION_UNKNOWN);

	move_dropdown(ctxpopup, obj);
	evas_object_show(ctxpopup);
}

static void
clicked_submit_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){

	cv_data *cv_d = data;

	dlog_print(DLOG_DEBUG, LOG_TAG, "submit button pressed");

	char
		title[100] = {},
		comment[100] = {},
		start_date[100] = {},
		finish_date[100] = {},
		sqlbuff[100] = {};

	double
		lon, lat;

	const char
		*title_val, *comment_val, *s_val, *f_val;

	elm_entry_cursor_begin_set(cv_d->entry_title);
	elm_entry_select_all(cv_d->entry_title);
	title_val = elm_entry_selection_get(cv_d->entry_title);

	elm_entry_cursor_begin_set(cv_d->entry_comment);
	elm_entry_select_all(cv_d->entry_comment);
	comment_val = elm_entry_selection_get(cv_d->entry_comment);

	elm_entry_cursor_begin_set(cv_d->entry_start_date);
	elm_entry_select_all(cv_d->entry_start_date);
	s_val = elm_entry_selection_get(cv_d->entry_start_date);

	elm_entry_cursor_begin_set(cv_d->entry_finish_date);
	elm_entry_select_all(cv_d->entry_finish_date);
	f_val = elm_entry_selection_get(cv_d->entry_finish_date);

	sprintf(title,"%s",title_val);
	sprintf(comment,"%s",comment_val);
	sprintf(start_date,"%s",s_val);
	sprintf(finish_date,"%s",f_val);
	lon = cv_d->longitude;
	lat = cv_d->latitude;
//	strcpy(title, title_val);

	sprintf(sqlbuff,"INSERT INTO LOCAL VALUES(\'%s\',\'%lf\',\'%lf\',\'%s\',\'%s\',\'e\',\'%s\',NULL);",comment,lon,lat,start_date,finish_date,title);

	dlog_print(DLOG_DEBUG, LOG_TAG, sqlbuff);

	sqlite3_exec(db,sqlbuff,NULL,0,NULL);

	showRecord();

	create_calendar_view(cv_d->ad);
}

void crate_map_view(Evas_Object *parent){

	Evas_Object *scroller, *grid, *map;

	scroller = elm_scroller_add(parent);
	elm_scroller_bounce_set(scroller,EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller,ELM_SCROLLER_POLICY_OFF,ELM_SCROLLER_POLICY_AUTO);

	grid = elm_grid_add(scroller);
	evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(grid, EVAS_HINT_FILL, EVAS_HINT_FILL);

	map = elm_map_add(grid);
	elm_map_zoom_mode_set(map,ELM_MAP_ZOOM_MODE_MANUAL);
	elm_map_zoom_set(map,15);
	elm_map_region_bring_in(map,127.04,37.28);
	elm_grid_pack(grid,map,0,0,100,100);
	evas_object_show(map);

	elm_object_content_set(scroller, grid);
}

static void clicked_time_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	Evas_Object *parent = data;

	crate_map_view(parent);
}

void create_create_view(void *parent){

	appdata_s *ad = parent;

	cv_data *cv_d = calloc(1,sizeof(cv_data));

	cv_d->ad = ad;
	cv_d->conform = cv_d->ad->conform;
//
//	Evas_Object *conform = cv_d->conform;
//	Evas_Object *entry = cv_d->entry;
//	Evas_Object *layout = cv_d->layout;
//	Evas_Object	*navi = cv_d->navi;
//	Evas_Object	*scroller = cv_d->scroller;
//	Evas_Object	*grid = cv_d->grid;
//	Evas_Object	*bg = cv_d->bg;
//	Evas_Object	*button = cv_d->button;
//	Evas_Object	*image = cv_d->image;
//	Evas_Object *entry_title = cv_d->entry_title;
//	Evas_Object *entry_comment = cv_d->entry_comment;
//	Evas_Object *entry_start_date = cv_d->entry_start_date;
//	Evas_Object *entry_finish_date = cv_d->entry_finish_date;
//	Elm_Object_Item *navi_it = cv_d->navi_it;

	schedule = calloc(1,sizeof(schedule_info_s));

	cv_d->layout = elm_layout_add(cv_d->conform);
	evas_object_size_hint_weight_set(cv_d->layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_layout_theme_set(cv_d->layout, "layout", "application", "default");
	evas_object_show(cv_d->layout);

	elm_object_content_set(cv_d->conform, cv_d->layout);

	cv_d->navi = elm_naviframe_add(cv_d->layout);

	cv_d->scroller = elm_scroller_add(cv_d->navi);
	elm_scroller_bounce_set(cv_d->scroller,EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(cv_d->scroller,ELM_SCROLLER_POLICY_OFF,ELM_SCROLLER_POLICY_AUTO);

	cv_d->grid = elm_grid_add(cv_d->scroller);
	evas_object_size_hint_weight_set(cv_d->grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(cv_d->grid, EVAS_HINT_FILL, EVAS_HINT_FILL);

	cv_d->bg = elm_bg_add(cv_d->grid);
	elm_win_resize_object_add(cv_d->grid, cv_d->bg);
	elm_object_content_set(cv_d->grid, cv_d->bg);
	elm_grid_pack(cv_d->grid, cv_d->bg, 0, 0, 100, 100);
	elm_bg_color_set(cv_d->bg, 38, 116, 212);
	evas_object_show(cv_d->bg);

	cv_d->entry_title = elm_entry_add(cv_d->grid);
	elm_entry_editable_set(cv_d->entry_title,EINA_TRUE);
	elm_object_part_text_set(cv_d->entry_title,"guide","Title");
	elm_entry_markup_filter_append(cv_d->entry_title, elm_entry_filter_limit_size, &title_size);
	evas_object_show(cv_d->entry_title);
	elm_entry_text_style_user_push(cv_d->entry_title,"default");
	elm_grid_pack(cv_d->grid,cv_d->entry_title,3,3,94,10);

	cv_d->entry_comment = elm_entry_add(cv_d->grid);
	elm_entry_editable_set(cv_d->entry_comment,EINA_TRUE);
	elm_object_part_text_set(cv_d->entry_comment,"guide","Memo");
	elm_entry_markup_filter_append(cv_d->entry_comment, elm_entry_filter_limit_size, &title_size);
	evas_object_show(cv_d->entry_comment);
	elm_grid_pack(cv_d->grid,cv_d->entry_comment,3,13,94,10);

	time_t t;
	time(&t);

	struct tm *time_st;

	time_st = localtime(&t);

	sprintf(c_time_str,"%04d-%02d-%02d %02d:%02d:%02d",
			time_st->tm_year+1900, time_st->tm_mon, time_st->tm_mday,time_st->tm_hour,time_st->tm_min,time_st->tm_sec);

//	strftime(c_time_str,256,"%x",c_time);

	cv_d->label = elm_label_add(cv_d->grid);
	elm_object_text_set(cv_d->label,"START DATE");
	evas_object_size_hint_weight_set(cv_d->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(cv_d->label);
	elm_grid_pack(cv_d->grid, cv_d->label,3,23,94,10);

	cv_d->entry_start_date = elm_entry_add(cv_d->grid);
	elm_entry_editable_set(cv_d->entry_start_date,EINA_TRUE);
	elm_object_part_text_set(cv_d->entry_start_date,"guide",c_time_str);
	elm_entry_markup_filter_append(cv_d->entry_start_date, elm_entry_filter_limit_size, &title_size);
	evas_object_show(cv_d->entry_start_date);
	elm_grid_pack(cv_d->grid,cv_d->entry_start_date,3,28,94,10);

	cv_d->label = elm_label_add(cv_d->grid);
	elm_object_text_set(cv_d->label,"FINISH DATE");
	evas_object_size_hint_weight_set(cv_d->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(cv_d->label);
	elm_grid_pack(cv_d->grid, cv_d->label,3,33,94,10);

	cv_d->entry_finish_date = elm_entry_add(cv_d->grid);
	elm_entry_editable_set(cv_d->entry_finish_date,EINA_TRUE);
	elm_object_part_text_set(cv_d->entry_finish_date,"guide",c_time_str);
	elm_entry_markup_filter_append(cv_d->entry_finish_date, elm_entry_filter_limit_size, &title_size);
	evas_object_show(cv_d->entry_finish_date);
	elm_grid_pack(cv_d->grid,cv_d->entry_finish_date,3,38,94,10);

	cv_d->button = elm_button_add(cv_d->grid);
	cv_d->image = elm_image_add(cv_d->button);
	elm_image_file_set(cv_d->image,ICON_DIR"/time_icon.png",NULL);
	elm_image_resizable_set(cv_d->image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(cv_d->button,"icon",cv_d->image);
	evas_object_smart_callback_add(cv_d->button,"clicked",clicked_time_btn_cb,cv_d);
	evas_object_show(cv_d->button);
	elm_grid_pack(cv_d->grid,cv_d->button,5,85,10,10);

	cv_d->button = elm_button_add(cv_d->grid);
	cv_d->image = elm_image_add(cv_d->button);
	elm_image_file_set(cv_d->image,ICON_DIR"/gps_icon.png",NULL);
	elm_image_resizable_set(cv_d->image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(cv_d->button,"icon",cv_d->image);
	evas_object_smart_callback_add(cv_d->button,"clicked",clicked_location_btn_cb,cv_d);
	evas_object_show(cv_d->button);
	elm_grid_pack(cv_d->grid,cv_d->button,45,85,10,10);

	cv_d->button = elm_button_add(cv_d->grid);
	cv_d->image = elm_image_add(cv_d->button);
	elm_image_file_set(cv_d->image,ICON_DIR"/tag1_icon.png",NULL);
	elm_image_resizable_set(cv_d->image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(cv_d->button,"icon",cv_d->image);
	evas_object_smart_callback_add(cv_d->button,"clicked",clicked_tag_btn_cb,cv_d);
	evas_object_show(cv_d->button);
	elm_grid_pack(cv_d->grid,cv_d->button,85,85,10,10);



	elm_object_content_set(cv_d->scroller, cv_d->grid);

	cv_d->navi_it = elm_naviframe_item_push(cv_d->navi,"Create Schedule",NULL,NULL,cv_d->scroller,NULL);

	cv_d->button = elm_button_add(cv_d->navi);
	cv_d->image = elm_image_add(cv_d->button);
	elm_image_file_set(cv_d->image,ICON_DIR"/cancel_icon.png",NULL);
	elm_image_resizable_set(cv_d->image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(cv_d->button,"icon",cv_d->image);
	evas_object_smart_callback_add(cv_d->button,"clicked",clicked_cancel_btn_cb,ad);
	elm_object_item_part_content_set(cv_d->navi_it,"title_left_btn",cv_d->button);

	cv_d->button = elm_button_add(cv_d->navi);
	cv_d->image = elm_image_add(cv_d->button);
	elm_image_file_set(cv_d->image,ICON_DIR"/ok_icon.png",NULL);
	elm_image_resizable_set(cv_d->image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(cv_d->button,"icon",cv_d->image);
	evas_object_smart_callback_add(cv_d->button,"clicked",clicked_submit_btn_cb,cv_d);
	elm_object_item_part_content_set(cv_d->navi_it,"title_right_btn",cv_d->button);

	elm_object_part_content_set(cv_d->layout, "elm.swallow.content", cv_d->navi);
}
