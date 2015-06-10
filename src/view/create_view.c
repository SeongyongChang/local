/*
 * create_view.c
 *
 *  Created on: Jun 10, 2015
 *      Author: seongyong
 */

#include "view/create_view.h"
#include "time.h"

schedule_info_s *schedule;

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
	Evas_Object *conform = data;

	create_calendar_view(conform);
}

void create_create_view(Evas_Object *parent){
	Evas_Object *conform = parent;
	Evas_Object
		*entry;

	Evas_Object
		*layout,
		*navi,
		*scroller,
		*grid,
		*bg,
		*button,
		*image;
	Elm_Object_Item *navi_it;

	schedule = calloc(1,sizeof(schedule_info_s));

	layout = elm_layout_add(conform);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_layout_theme_set(layout, "layout", "application", "default");
	evas_object_show(layout);

	elm_object_content_set(conform, layout);

	navi = elm_naviframe_add(layout);

	scroller = elm_scroller_add(navi);
	elm_scroller_bounce_set(scroller,EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller,ELM_SCROLLER_POLICY_OFF,ELM_SCROLLER_POLICY_AUTO);

	grid = elm_grid_add(scroller);
	evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(grid, EVAS_HINT_FILL, EVAS_HINT_FILL);

	bg = elm_bg_add(grid);
	elm_win_resize_object_add(grid, bg);
	elm_object_content_set(grid, bg);
	elm_grid_pack(grid, bg, 0, 0, 100, 100);
	elm_bg_color_set(bg, 38, 116, 212);
	evas_object_show(bg);

	entry = elm_entry_add(grid);
	elm_entry_editable_set(entry,EINA_TRUE);
	elm_object_part_text_set(entry,"guide","Title");
	elm_entry_markup_filter_append(entry, elm_entry_filter_limit_size, &title_size);
	evas_object_show(entry);
	elm_grid_pack(grid,entry,3,3,94,10);

	entry = elm_entry_add(grid);
	elm_entry_editable_set(entry,EINA_TRUE);
	elm_object_part_text_set(entry,"guide","Memo");
	elm_entry_markup_filter_append(entry, elm_entry_filter_limit_size, &title_size);
	evas_object_show(entry);
	elm_grid_pack(grid,entry,3,18,94,10);




//	sprintf(time_str_st,"%d 년 %d월 %d일 %d시 %d분 %d초",
//			time_st->tm_year+1900, time_st->tm_mon, time_st->tm_mday,time_st->tm_hour,time_st->tm_min,time_st->tm_sec);

	strftime(c_time_str,256,"%x",c_time);


	entry = elm_entry_add(grid);
	elm_entry_editable_set(entry,EINA_TRUE);
	elm_object_part_text_set(entry,"guide",c_time_str);
	elm_entry_markup_filter_append(entry, elm_entry_filter_limit_size, &title_size);
	evas_object_show(entry);
	elm_grid_pack(grid,entry,3,28,94,10);







	elm_object_content_set(scroller, grid);

	navi_it = elm_naviframe_item_push(navi,"Create View",NULL,NULL,scroller,NULL);

	button = elm_button_add(navi);
	image = elm_image_add(button);
	elm_image_file_set(image,ICON_DIR"/cancel_icon.png",NULL);
	elm_image_resizable_set(image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(button,"icon",image);
	evas_object_smart_callback_add(button,"clicked",clicked_cancel_btn_cb,conform);
	elm_object_item_part_content_set(navi_it,"title_left_btn",button);

	button = elm_button_add(navi);
	image = elm_image_add(button);
	elm_image_file_set(image,ICON_DIR"/ok_icon.png",NULL);
	elm_image_resizable_set(image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(button,"icon",image);
	evas_object_smart_callback_add(button,"clicked",NULL,conform);
	elm_object_item_part_content_set(navi_it,"title_right_btn",button);

	elm_object_part_content_set(layout, "elm.swallow.content", navi);
}
