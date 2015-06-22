/*
 * local_db.c
 *
 *  Created on: Jun 21, 2015
 *      Author: seongyong
 */

#include "db/local_db.h"

int callback(void *counter, int argc, char **argv, char **azColName)
{
   int *localcounter = (int *)counter;
   int i;

   dlog_print(DLOG_DEBUG, LOG_TAG, "-%d: ", *localcounter);

   for (i = 0; i<argc; i++)
      dlog_print(DLOG_DEBUG, LOG_TAG, "%s = %s | ", azColName[i], argv[i] ? argv[i] : "NULL");

   (*localcounter)++;
   dlog_print(DLOG_DEBUG, LOG_TAG, "\n");


   return 0;
}

int get_tag_cb(void *counter, int argc, char **argv, char **azColName)
{
   int *localcounter = (int *)counter;
   int i;



   dlog_print(DLOG_DEBUG, LOG_TAG, "-%d: ", *localcounter);

   for (i = 0; i<argc; i++){
      dlog_print(DLOG_DEBUG, LOG_TAG, "%s = %s | ", azColName[i], argv[i] ? argv[i] : "NULL");
      schedule_tag[i] = argv[i] ? argv[i] : "NULL";
   }
   (*localcounter)++;
   dlog_print(DLOG_DEBUG, LOG_TAG, "\n");



   return 0;
}

void initDb(){

	sqlite3_config(SQLITE_CONFIG_URI,1);

	sqlite3_initialize();

	char* resource = app_get_data_path();
	int siz = strlen(resource)+10;

	char* path = malloc(sizeof(char)*siz);

	strncat(path, resource, siz);
	strncat(path, "local.db", siz);

//	memset(path, 0 , siz); // db data initializer

	sqlite3_open(path, &db);

	free(path);
}

void createScheduleTable(){
	int ret;
	char *ErrMsg;
	char *sql =
			"CREATE TABLE IF NOT EXISTS LOCAL(" \
			"COMMENT TEXT," \
			"LOCATION_X DOUBLE," \
			"LOCATION_Y DOUBLE," \
			"TIME_START DATETIME NOT NULL," \
			"TIME_FINISH DATETIME," \
			"TAG TEXT," \
			"TITLE TEXT NOT NULL," \
			"KEY INTEGER PRIMARY KEY);";

	sqlite3_exec(db, sql, NULL, 0, &ErrMsg);
}

void createTagTable(){
	int ret;
		char *ErrMsg;
		char *sql =
				"CREATE TABLE IF NOT EXISTS TAG(" \
				"TAG TEXT PRIMARY KEY);";

		sqlite3_exec(db, sql, NULL, 0, &ErrMsg);
}

void showRecord(){
	   char *sql = "SELECT * FROM LOCAL";
	   int counter = 0, ret = 0;
	   char *ErrMsg;

	   sqlite3_exec(db, sql, callback, &counter, &ErrMsg);

	   return;
}

void showTags(){
	   char *sql = "SELECT * FROM TAG";
	   int counter = 0, ret = 0;
	   char *ErrMsg;

	   sqlite3_exec(db, sql, callback, &counter, &ErrMsg);

	   return;
}

void getTags(){
	   char *sql = "SELECT * FROM TAG";
	   int counter = 0, ret = 0;
	   char *ErrMsg;

	   sqlite3_exec(db, sql, get_tag_cb, &counter, &ErrMsg);

	   return;
}

void insertTag(char* tag){
	dlog_print(DLOG_DEBUG, LOG_TAG, tag);
	char sqlbuff[100];
	sprintf(sqlbuff,"INSERT INTO TAG VALUES(\'%s\');",tag);
	dlog_print(DLOG_DEBUG, LOG_TAG, sqlbuff);
	sqlite3_exec(db,sqlbuff,NULL,0,NULL);
}
