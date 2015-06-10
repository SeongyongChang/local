/*
 * calendar_view.c
 *
 *  Created on: Jun 10, 2015
 *      Author: seongyong
 */

#include "view/calendar_view.h"

static void clicked_todo_list_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	Evas_Object *conform = data;

	create_todo_list_view(conform);
}

static void clicked_create_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	Evas_Object *conform = data;

	create_create_view(conform);
}

void set_calendar_view(Evas_Object *parent){
	Evas_Object *navi = parent;
	Evas_Object *scroller,
				*grid,
				*table,
				*bg,
				*label,
				*button,
				*image,
				*box;
	Elm_Object_Item *nf_it;

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

	table = elm_table_add(grid);

	button = elm_button_add(grid);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button,"hi");
	elm_table_pack(table, button, 0, 0, 1, 1);
	evas_object_show(button);

	button = elm_button_add(grid);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button,"hi");
	elm_table_pack(table, button, 1, 1, 1, 1);
	evas_object_show(button);

	button = elm_button_add(grid);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button,"hi");
	elm_table_pack(table, button, 2, 2, 1, 1);
	evas_object_show(button);

	button = elm_button_add(grid);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button,"hi");
	elm_table_pack(table, button, 3, 3, 1, 1);
	evas_object_show(button);

	button = elm_button_add(grid);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button,"hi");
	elm_table_pack(table, button, 4, 4, 1, 1);
	evas_object_show(button);

	button = elm_button_add(grid);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button,"hi");
	elm_table_pack(table, button, 5, 5, 1, 1);
	evas_object_show(button);

	button = elm_button_add(grid);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button,"hi");
	elm_table_pack(table, button, 6, 5, 1, 1);
	evas_object_show(button);

	button = elm_button_add(grid);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button,"hi");
	elm_table_pack(table, button, 6, 5, 1, 1);
	evas_object_show(button);

	evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(table, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(grid, table, 0, 0, 100, 100);
	evas_object_show(table);







	nf_it = elm_naviframe_item_push(navi,"Sun  Mon  Tue  Wed  Thu  Fri  Sat",NULL,NULL,scroller,NULL);



}

void create_calendar_view(Evas_Object *parent){

	Evas_Object *conform = parent;

	Evas_Object
		*layout,
		*navi,
		*scroller,
		*calendar_layout,
		*calendar_navi,
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

	calendar_layout = elm_layout_add(scroller);
	elm_layout_theme_set(calendar_layout, "layout", "application", "default");
	evas_object_size_hint_weight_set(calendar_layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(calendar_layout, EVAS_HINT_FILL, EVAS_HINT_FILL);

	elm_object_content_set(scroller, calendar_layout);

	calendar_navi = elm_naviframe_add(calendar_layout);

	set_calendar_view(calendar_navi);

	elm_object_part_content_set(calendar_layout, "elm.swallow.content", calendar_navi);

	strftime(c_time_str,256,"%x",c_time);

	navi_it = elm_naviframe_item_push(navi,c_time_str,NULL,NULL,scroller,NULL);

	button = elm_button_add(navi);
	image = elm_image_add(button);
	elm_image_file_set(image,ICON_DIR"/to_do_list_icon.png",NULL);
	elm_image_resizable_set(image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(button,"icon",image);
	evas_object_smart_callback_add(button,"clicked",clicked_todo_list_btn_cb,conform);
	elm_object_item_part_content_set(navi_it,"title_left_btn",button);

	button = elm_button_add(navi);
	image = elm_image_add(button);
	elm_image_file_set(image,ICON_DIR"/create_icon.png",NULL);
	elm_image_resizable_set(image,EINA_TRUE,EINA_TRUE);
	elm_object_part_content_set(button,"icon",image);
	evas_object_smart_callback_add(button,"clicked",clicked_create_btn_cb,conform);
	elm_object_item_part_content_set(navi_it,"title_right_btn",button);

	elm_object_part_content_set(layout, "elm.swallow.content", navi);
}
