/*
 * local_db.h
 *
 *  Created on: Jun 21, 2015
 *      Author: seongyong
 */

#ifndef LOCAL_DB_H_
#define LOCAL_DB_H_

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#include <sqlite3.h>

#include "local.h"

sqlite3 *db;

void initDb();
void createScheduleTable();
void createTagTable();
void showRecord();
void showTags();
void getTags();
void insertTag(char* tag);

#endif /* LOCAL_DB_H_ */
