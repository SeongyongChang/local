#include <tizen.h>
#include "local.h"
#include "db/local_db.h"

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info){
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void clicked_strat_btn_cb(void *data, Evas_Object *obj EINA_UNUSED, void *event_info EINA_UNUSED){
	appdata_s *ad = data;

	create_calendar_view(ad);
}


static void
create_base_gui(appdata_s *ad)
{
	Evas_Object
		*grid,
		*bg,
		*button;

	int i;

	for(i = 0; i < MAX_NUMBER_OF_SCHEDULE; i++){
		local_schedules[i] = calloc(1, sizeof(schedule_info_s));
		schedule_tag[i] = calloc(1,sizeof(tag_c));
	}

//	strcpy(schedule_tag[0]->tag,"ALL");
//	strcpy(schedule_tag[1]->tag,"NONE");
//	strcpy(schedule_tag[2]->tag,"WORK");
//	strcpy(schedule_tag[3]->tag,"PERSONAL");
//	strcpy(schedule_tag[4]->tag,"EXCERCISE");
//
//	strcpy(local_schedules[0]->title,"schedule0");
//	strcpy(local_schedules[1]->title,"schedule1");
//	strcpy(local_schedules[2]->title,"schedule2");
//	strcpy(local_schedules[3]->title,"schedule3");
//	strcpy(local_schedules[4]->title,"schedule4");
//	strcpy(local_schedules[5]->title,"schedule5");
//	strcpy(local_schedules[6]->title,"schedule6");
//	strcpy(local_schedules[7]->title,"schedule7");
//	strcpy(local_schedules[8]->title,"schedule8");
//	strcpy(local_schedules[9]->title,"schedule9");
//
//	strcpy(local_schedules[0]->tag,"WORK");
//	strcpy(local_schedules[1]->tag,"WORK");
//	strcpy(local_schedules[2]->tag,"EXCERCISE");
//	strcpy(local_schedules[3]->tag,"PERSONAL");
//	strcpy(local_schedules[4]->tag,"PERSONAL");
//	strcpy(local_schedules[5]->tag,"WORK");
//	strcpy(local_schedules[6]->tag,"NONE");
//	strcpy(local_schedules[7]->tag,"WORK");
//	strcpy(local_schedules[8]->tag,"WORK");
//	strcpy(local_schedules[9]->tag,"EXERCISE");

//sqlite start

	initDb();

	createScheduleTable();
	createTagTable();

	char *sql = "WORK";

	insertTag(sql);
	insertTag("STUDY");

	showRecord();
	showTags();


//	char *sqlbuff = "INSERT INTO LOCAL VALUES(\'a\',\'b\',\'c\',\'d\',\'2015-05-12\',\'f\',\'g\',1);";
//
//	sqlite3_exec(db,sqlbuff,NULL,0,NULL);
//
//	char *sqlbuff1 = "INSERT INTO LOCAL VALUES(\'x\',\'y\',\'z\',\'w\',\'2015-05-12\',\'s\',\'q\',2);";
//
//	sqlite3_exec(db,sqlbuff1,NULL,0,NULL);
//
//	ShowRecords();


//

	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	grid = elm_grid_add(ad->conform);
	evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, grid);

	bg = elm_bg_add(grid);
	elm_win_resize_object_add(grid, bg);
	elm_grid_pack(grid, bg, 0, 0, 100, 100);
	elm_bg_color_set(bg, 38, 116, 212);
	evas_object_show(bg);

	bg = elm_bg_add(grid);
	elm_bg_color_set(bg, 38, 116, 212);
	elm_bg_file_set(bg,ICON_DIR"/local_logo.png",NULL);
	elm_bg_option_set(bg,ELM_BG_OPTION_STRETCH);
	evas_object_show(bg);
	elm_grid_pack(grid, bg, 25, 10, 50, 30);

	button = elm_button_add(grid);
	evas_object_size_hint_weight_set(button,EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button,EVAS_HINT_FILL,EVAS_HINT_FILL);
	elm_object_text_set(button, "START");
	evas_object_smart_callback_add(button, "clicked", clicked_strat_btn_cb, ad);
	evas_object_show(button);
	elm_grid_pack(grid, button, 30, 75, 40, 10);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	time(&time_ptr);
	c_time = localtime(&time_ptr);




	int temp[12] = {31,28,31,30,31,30,31,31,30,31,30,31};

	int i;
	for(i = 0; i < 12; i++)
		day_of_month[i] = temp[i];

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
