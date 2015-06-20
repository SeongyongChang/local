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

void initDb(){

	sqlite3_config(SQLITE_CONFIG_URI,1);

	sqlite3_initialize();

	char* resource = app_get_data_path();
	int siz = strlen(resource)+10;

	char* path = malloc(sizeof(char)*siz);

	strncat(path, resource, siz);
	strncat(path, "local.db", siz);

	memset(path, 0 , siz);

	sqlite3_open(path, &db);

	free(path);
}

void createTable(){
	int ret;
	char *ErrMsg;
	char *sql =
			"CREATE TABLE IF NOT EXISTS LOCAL(" \
			"COMMENT TEXT," \
			"LOCATION_X TEXT," \
			"LOCATION_Y TEXT," \
			"TIME_START DATETIME NOT NULL," \
			"TIME_FINISH DATETIME," \
			"TAG TEXT," \
			"TITLE TEXT NOT NULL," \
			"KEY INTEGER PRIMARY KEY);";

	sqlite3_exec(db, sql, NULL, 0, &ErrMsg);
}

void showRecord(){
	   char *sql = "SELECT * FROM LOCAL";
	   int counter = 0, ret = 0;
	   char *ErrMsg;

	   sqlite3_exec(db, sql, callback, &counter, &ErrMsg);

	   return;
}