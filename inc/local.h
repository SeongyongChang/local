#ifndef __local_H__
#define __local_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#include "view/calendar_view.h"
#include "view/todo_list_view.h"
#include "view/create_view.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "local"

#if !defined(PACKAGE)
#define PACKAGE "org.tizen.local"
#endif

#define ICON_DIR "/opt/usr/apps/org.tizen.local/res/"
#define MAX_NUMBER_OF_SCHEDULE 100

typedef struct schedule_info{
	char start_date[20];
	char finish_date[20];
	char location[20];
	char location_alarm_flag[20];
	char title[20];
	char memo[20];
	char tag[20];
}schedule_info_s;

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
} appdata_s;

schedule_info_s *local_schedules[MAX_NUMBER_OF_SCHEDULE];

#endif /* __local_H__ */
