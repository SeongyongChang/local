/*
 * todo_list_view.c
 *
 *  Created on: Jun 10, 2015
 *      Author: seongyong
 */

#include "view/todo_list_view.h"

int current_tag = 0;

static void clicked_calendar_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	appdata_s *ad = data;

	create_calendar_view(ad);
}

static void clicked_create_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	appdata_s *ad = data;

	create_create_view(ad);
}

void set_todo_list_view(Evas_Object *parent){
	Evas_Object *navi = parent;
	Evas_Object *scroller,
				*grid,
				*table,
				*bg,
				*label,
				*button,
				*image,
				*box;
	Elm_Object_Item *navi_it;

	scroller = elm_scroller_add(navi);
	elm_scroller_bounce_set(scroller,EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller,ELM_SCROLLER_POLICY_OFF,ELM_SCROLLER_POLICY_AUTO);

	grid = elm_grid_add(scroller);
	evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(grid, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_content_set(scroller, grid);

	bg = elm_bg_add(grid);
	elm_win_resize_object_add(grid, bg);
	elm_object_content_set(grid, bg);
	elm_grid_pack(grid, bg, 0, 0, 100, 100);
	elm_bg_color_set(bg, 38, 116, 212);
	evas_object_show(bg);




	navi_it = elm_naviframe_item_push(navi,schedule_tag[current_tag]->tag,NULL,NULL,scroller,NULL);

	button = elm_button_add(navi);
	image = elm_image_add(button);
	elm_image_file_set(image,ICON_DIR"/left_arrow.png",NULL);
	elm_image_resizable_set(image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(button,"icon",image);
//	evas_object_smart_callback_add(button,"clicked",clicked_todo_list_btn_cb,conform);
	elm_object_item_part_content_set(navi_it,"title_left_btn",button);

	button = elm_button_add(navi);
	image = elm_image_add(button);
	elm_image_file_set(image,ICON_DIR"/right_arrow.png",NULL);
	elm_image_resizable_set(image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(button,"icon",image);
//	evas_object_smart_callback_add(button,"clicked",clicked_create_btn_cb,conform);
	elm_object_item_part_content_set(navi_it,"title_right_btn",button);

}

void create_todo_list_view(void *parent){
	appdata_s *ad = parent;
	Evas_Object *conform = ad->conform;

	Evas_Object
		*layout,
		*navi,
		*scroller,
		*todo_layout,
		*todo_navi,
		*grid,
		*bg,
		*button,
		*image;
	Elm_Object_Item *navi_it;

	layout = elm_layout_add(conform);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_layout_theme_set(layout, "layout", "application", "default");
	evas_object_show(layout);

	elm_object_content_set(conform, layout);

	navi = elm_naviframe_add(layout);

	scroller = elm_scroller_add(navi);
	elm_scroller_bounce_set(scroller,EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller,ELM_SCROLLER_POLICY_OFF,ELM_SCROLLER_POLICY_AUTO);

	todo_layout = elm_layout_add(scroller);
	elm_layout_theme_set(todo_layout,"layout","application","default");
	evas_object_size_hint_weight_set(todo_layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(todo_layout, EVAS_HINT_FILL, EVAS_HINT_FILL);

	elm_object_content_set(scroller, todo_layout);

	todo_navi = elm_naviframe_add(todo_layout);

	set_todo_list_view(todo_navi);

	elm_object_part_content_set(todo_layout, "elm.swallow.content", todo_navi);

	navi_it = elm_naviframe_item_push(navi,"Todo List",NULL,NULL,scroller,NULL);

	button = elm_button_add(navi);
	image = elm_image_add(button);
	elm_image_file_set(image,ICON_DIR"/calendar_icon.png",NULL);
	elm_image_resizable_set(image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(button,"icon",image);
	evas_object_smart_callback_add(button,"clicked",clicked_calendar_btn_cb,ad);
	elm_object_item_part_content_set(navi_it,"title_left_btn",button);

	button = elm_button_add(navi);
	image = elm_image_add(button);
	elm_image_file_set(image,ICON_DIR"/create_icon.png",NULL);
	elm_image_resizable_set(image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(button,"icon",image);
	evas_object_smart_callback_add(button,"clicked",clicked_create_btn_cb,ad);
	elm_object_item_part_content_set(navi_it,"title_right_btn",button);

//	Evas_Object *toolbar = elm_toolbar_add(navi);
//	elm_toolbar_shrink_mode_set(toolbar, ELM_TOOLBAR_SHRINK_EXPAND);
//	elm_toolbar_transverse_expanded_set(toolbar, EINA_TRUE);
//	elm_object_item_part_content_set(navi_it, "toolbar", toolbar);
//	elm_toolbar_item_append(toolbar, NULL, NULL, NULL, NULL);


	elm_object_part_content_set(layout, "elm.swallow.content", navi);
}
