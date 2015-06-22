#ifndef __local_H__
#define __local_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#include <sqlite3.h>
#include <string.h>

#include "view/calendar_view.h"
#include "view/todo_list_view.h"
#include "view/create_view.h"
#include "db/local_db.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "local"

#if !defined(PACKAGE)
#define PACKAGE "org.tizen.local"
#endif

#define ELM_EDJ "/opt/usr/apps/org.tizen.local/res/ui_controls.edj"
#define ICON_DIR "/opt/usr/apps/org.tizen.local/res/"
#define FILE_DIR "/opt/usr/apps/org.tizen.local/res/"
#define MAX_NUMBER_OF_SCHEDULE 100

typedef struct schedule_info{
	char start_date[20];
	char finish_date[20];
	char location[20];
	char location_alarm_flag[20];
	char title[20];
	char memo[20];
	char tag[20];
	struct schedule_info *next;
}schedule_info_s;

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
} appdata_s;

typedef struct tag_data{
	char tag[20];
	int red;
	int green;
	int blue;
}tag_c;

time_t time_ptr;
struct tm *c_time;
char c_time_str[40];

schedule_info_s *local_schedules[MAX_NUMBER_OF_SCHEDULE];
tag_c *schedule_tag[MAX_NUMBER_OF_SCHEDULE];
int day_of_month[12];

int num_of_schedule;



#endif /* __local_H__ */
