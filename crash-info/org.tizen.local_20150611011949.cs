S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: local
PID: 17973
Date: 2015-06-11 01:19:49+0900
Executable File Path: /opt/usr/apps/org.tizen.local/bin/local
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x557863aa

Register Information
r0   = 0xbee1ab98, r1   = 0x00000100
r2   = 0xb4f34200, r3   = 0x557863a2
r4   = 0x00000000, r5   = 0xb82bdd20
r6   = 0xb816ade8, r7   = 0xbee1abd8
r8   = 0x00000000, r9   = 0xb8249f98
r10  = 0xb8316f20, fp   = 0x00000001
ip   = 0xbee1ab1f, sp   = 0xbee1ab10
lr   = 0xb6ca3f14, pc   = 0xb6ca2368
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    220332 KB
Buffers:     36524 KB
Cached:     145112 KB
VmPeak:      70288 KB
VmSize:      70284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16736 KB
VmRSS:       16732 KB
VmData:      22620 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23768 KB
VmPTE:          54 KB
VmSwap:          0 KB

Maps Information
b2f58000 b2f5d000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/linux-gnueabi-armv7l-1.7.99/module.so
b2f70000 b2f80000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2fc0000 b2fc5000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b445c000 b445d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b4465000 b446c000 r-xp /usr/lib/libfeedback.so.0.1.4
b4482000 b4483000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b448b000 b448d000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b4495000 b4496000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b449e000 b44b5000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b4611000 b4615000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b461e000 b4628000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4962000 b4a2c000 r-xp /usr/lib/libCOREGL.so.4.0
b4a3d000 b4a42000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4a4a000 b4a4c000 r-xp /usr/lib/libiniparser.so.0
b4a56000 b4b95000 r-xp /usr/lib/libicui18n.so.51.1
b4ba5000 b4ba7000 r-xp /usr/lib/libdri2.so.0.0.0
b4baf000 b4bb6000 r-xp /usr/lib/libtbm.so.1.0.0
b4bbe000 b4bc5000 r-xp /usr/lib/libdrm.so.2.4.0
b4bce000 b4bd6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4bde000 b4be3000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4beb000 b4bf0000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4bf9000 b4bfa000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4c03000 b4c1b000 r-xp /usr/lib/libpng12.so.0.50.0
b4c23000 b4c26000 r-xp /usr/lib/libEGL.so.1.4
b4c2e000 b4c3c000 r-xp /usr/lib/libGLESv2.so.2.0
b4c45000 b4c49000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4c52000 b4c5a000 r-xp /usr/lib/libui-extension.so.0.1.0
b4c5b000 b4c5e000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4c66000 b4c69000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4c71000 b4d27000 r-xp /usr/lib/libcairo.so.2.11200.14
b4d32000 b4d44000 r-xp /usr/lib/libtts.so
b4d4c000 b4d62000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4d6a000 b4d6c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4d74000 b4d7b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4d86000 b4d90000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4d99000 b4da3000 r-xp /lib/libnss_files-2.13.so
b4dac000 b4dbe000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4dc6000 b4ddc000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4de4000 b4eb2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4ec9000 b4eed000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4ef6000 b4efc000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f04000 b4f12000 r-xp /usr/lib/libail.so.0.1.0
b4f1a000 b4f1c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f25000 b4f2a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f32000 b4f35000 r-xp /opt/usr/apps/org.tizen.local/bin/local
b4f3d000 b4f3e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f47000 b4f4b000 r-xp /usr/lib/libogg.so.0.7.1
b4f53000 b4f75000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f7d000 b5061000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b5075000 b50a6000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a40000 b5ad4000 r-xp /usr/lib/libstdc++.so.6.0.16
b5ae7000 b5ae9000 r-xp /usr/lib/libXau.so.6.0.0
b5af1000 b5afb000 r-xp /usr/lib/libspdy.so.0.0.0
b5b04000 b5b50000 r-xp /usr/lib/libssl.so.1.0.0
b5b5d000 b5b8b000 r-xp /usr/lib/libidn.so.11.5.44
b5b93000 b5b9d000 r-xp /usr/lib/libcares.so.2.1.0
b5ba5000 b5bc6000 r-xp /usr/lib/libexif.so.12.3.3
b5bd9000 b5c1e000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c2c000 b5c42000 r-xp /lib/libexpat.so.1.5.2
b5c4b000 b5d30000 r-xp /usr/lib/libicuuc.so.51.1
b5d45000 b5d79000 r-xp /usr/lib/libicule.so.51.1
b5d82000 b5d95000 r-xp /usr/lib/libxcb.so.1.1.0
b5d9d000 b5dda000 r-xp /usr/lib/libcurl.so.4.3.0
b5de3000 b5dec000 r-xp /usr/lib/libethumb.so.1.7.99
b5df5000 b5df7000 r-xp /usr/lib/libctxdata.so.0.0.0
b5dff000 b5e0c000 r-xp /usr/lib/libremix.so.0.0.0
b5e14000 b5e15000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e1d000 b5e34000 r-xp /usr/lib/liblua-5.1.so
b5e3d000 b5e44000 r-xp /usr/lib/libembryo.so.1.7.99
b5e4c000 b5e6f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e87000 b5edd000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5eea000 b5f3d000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f48000 b5f70000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f71000 b5fb7000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5fc0000 b5fd3000 r-xp /usr/lib/libfribidi.so.0.3.1
b5fdb000 b5fde000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5fe6000 b5fea000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5ff2000 b5ff7000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6000000 b600a000 r-xp /usr/lib/libXext.so.6.4.0
b6012000 b60f3000 r-xp /usr/lib/libX11.so.6.3.0
b60fe000 b6101000 r-xp /usr/lib/libXtst.so.6.1.0
b6109000 b610f000 r-xp /usr/lib/libXrender.so.1.3.0
b6117000 b611c000 r-xp /usr/lib/libXrandr.so.2.2.0
b6124000 b6125000 r-xp /usr/lib/libXinerama.so.1.0.0
b612e000 b6136000 r-xp /usr/lib/libXi.so.6.1.0
b6137000 b613a000 r-xp /usr/lib/libXfixes.so.3.1.0
b6142000 b6144000 r-xp /usr/lib/libXgesture.so.7.0.0
b614c000 b614e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6156000 b6157000 r-xp /usr/lib/libXdamage.so.1.1.0
b6160000 b6166000 r-xp /usr/lib/libXcursor.so.1.0.2
b616f000 b6188000 r-xp /usr/lib/libecore_con.so.1.7.99
b6192000 b6198000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61a0000 b61a8000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61b0000 b61b9000 r-xp /usr/lib/libedbus.so.1.7.99
b61c1000 b621e000 r-xp /usr/lib/libedje.so.1.7.99
b6227000 b6238000 r-xp /usr/lib/libecore_input.so.1.7.99
b6240000 b6245000 r-xp /usr/lib/libecore_file.so.1.7.99
b624d000 b6266000 r-xp /usr/lib/libeet.so.1.7.99
b6277000 b627b000 r-xp /usr/lib/libappcore-common.so.1.1
b6283000 b634a000 r-xp /usr/lib/libevas.so.1.7.99
b636f000 b6390000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6399000 b63c8000 r-xp /usr/lib/libecore_x.so.1.7.99
b63d2000 b6509000 r-xp /usr/lib/libelementary.so.1.7.99
b651f000 b6520000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b6528000 b652c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b6537000 b653a000 r-xp /lib/libgpg-error.so.0.5.0
b6542000 b659a000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65a4000 b65d0000 r-xp /usr/lib/libsystemd.so.0.0.1
b65d9000 b65db000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65e4000 b66af000 r-xp /usr/lib/libxml2.so.2.7.8
b66bd000 b66cd000 r-xp /lib/libresolv-2.13.so
b66d1000 b66e7000 r-xp /lib/libz.so.1.2.5
b66ef000 b66f1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66f9000 b66fe000 r-xp /usr/lib/libffi.so.5.0.10
b6707000 b6708000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6710000 b6713000 r-xp /lib/libattr.so.1.1.0
b671b000 b671e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6726000 b672d000 r-xp /usr/lib/libvconf.so.0.2.45
b6736000 b68de000 r-xp /usr/lib/libcrypto.so.1.0.0
b68ff000 b6915000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b691d000 b6986000 r-xp /lib/libm-2.13.so
b698f000 b69cf000 r-xp /usr/lib/libeina.so.1.7.99
b69d8000 b6a0c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a15000 b6ae9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6af5000 b6afa000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b03000 b6b09000 r-xp /lib/librt-2.13.so
b6b12000 b6b19000 r-xp /lib/libcrypt-2.13.so
b6b49000 b6b4c000 r-xp /lib/libcap.so.2.21
b6b54000 b6b56000 r-xp /usr/lib/libiri.so
b6b5e000 b6b7d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b85000 b6b9b000 r-xp /usr/lib/libecore.so.1.7.99
b6bb1000 b6bb6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bbf000 b6bd6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bdf000 b6bea000 r-xp /lib/libunwind.so.8.0.1
b6c17000 b6d32000 r-xp /lib/libc-2.13.so
b6d40000 b6d48000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d50000 b6d7a000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d83000 b6d86000 r-xp /usr/lib/libbundle.so.0.1.22
b6d8e000 b6d90000 r-xp /lib/libdl-2.13.so
b6d99000 b6d9c000 r-xp /usr/lib/libsmack.so.1.0.0
b6da4000 b6e74000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e75000 b6eda000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6ee4000 b6ef6000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6efe000 b6f12000 r-xp /lib/libpthread-2.13.so
b6f1d000 b6f1f000 r-xp /usr/lib/libdlog.so.0.0.0
b6f27000 b6f32000 r-xp /usr/lib/libaul.so.0.1.0
b6f44000 b6f47000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f51000 b6f55000 r-xp /usr/lib/libsys-assert.so
b6f5e000 b6f7b000 r-xp /lib/ld-2.13.so
b6f84000 b6f89000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b80c8000 b80f2000 rw-p [heap]
b80f2000 b8372000 rw-p [heap]
bedfb000 bee1c000 rwxp [stack]
End of Maps Information

Callstack Information (PID:17973)
Call Stack Count: 2
 0: (0xb6ca2368) [/lib/libc.so.6] + 0x8b368
 1: (0xf72a60) (null)
End of Call Stack

Package Information
Package Name: org.tizen.local
Package ID : org.tizen.local
Version: 1.0.0
Package Type: rpm
App Name: local
App ID: org.tizen.local
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
oy handle: 0xb846b910
06-11 01:15:00.182+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-11 01:15:00.212+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-11 01:15:00.242+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
06-11 01:15:00.262+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
06-11 01:15:00.302+0900 E/weather-live(16591): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-11 01:15:00.322+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-11 01:15:00.322+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-11 01:15:00.352+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb8218458]
06-11 01:15:00.352+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:15:00.352+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb8218458
06-11 01:15:00.362+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-11 01:15:00.392+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-11 01:15:00.422+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
06-11 01:15:00.442+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
06-11 01:15:00.482+0900 E/weather-live(16591): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-11 01:15:00.502+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-11 01:15:00.502+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-11 01:15:00.532+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb83697e8]
06-11 01:15:00.532+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:15:00.532+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb83697e8
06-11 01:15:00.552+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-11 01:15:00.592+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-11 01:15:00.632+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
06-11 01:15:00.662+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
06-11 01:15:00.712+0900 E/weather-common(16591): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
06-11 01:15:00.712+0900 E/weather-common(16591): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
06-11 01:15:00.782+0900 E/cluster-home(  599): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-11 01:15:01.242+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 1
06-11 01:15:01.302+0900 I/CAPI_APPFW_APPLICATION(16643): app_main.c: ui_app_main(699) > app_efl_main
06-11 01:15:01.342+0900 I/UXT     (16643): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-11 01:15:01.362+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 01:15:01.362+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 01:15:01.362+0900 E/RESOURCED(  773): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 397
06-11 01:15:01.372+0900 I/Tizen::App(  934): (499) > LaunchedApp(org.tizen.testuicontrolsample)
06-11 01:15:01.372+0900 I/Tizen::App(  934): (733) > Finished invoking application event listener for org.tizen.testuicontrolsample, 16643.
06-11 01:15:01.382+0900 I/Tizen::App(  965): (733) > Finished invoking application event listener for org.tizen.testuicontrolsample, 16643.
06-11 01:15:01.392+0900 I/CAPI_APPFW_APPLICATION(16643): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-11 01:15:01.582+0900 E/EFL     (16643): evas_main<16643> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-11 01:15:01.592+0900 E/EFL     (16643): evas_main<16643> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-11 01:15:01.702+0900 I/CAPI_APPFW_APPLICATION(16643): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-11 01:15:01.712+0900 I/APP_CORE(16643): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-11 01:15:01.712+0900 I/APP_CORE(16643): appcore-efl.c: __do_app(511) > [APP 16643] Initial Launching, call the resume_cb
06-11 01:15:01.712+0900 I/CAPI_APPFW_APPLICATION(16643): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-11 01:15:01.752+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=16643
06-11 01:15:01.782+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 01:15:01.792+0900 W/APP_CORE(16643): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4e00002
06-11 01:15:01.792+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.testuicontrolsample, pid = 16643"
06-11 01:15:01.812+0900 I/MALI    (  599): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8239f88] swap changed from sync to async
06-11 01:15:01.842+0900 I/Tizen::System(  965): (259) > Active app [org.tizen.], current [com.samsun] 
06-11 01:15:01.842+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 01:15:01.852+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 01:15:01.882+0900 I/CAPI_APPFW_APPLICATION(  599): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-11 01:15:01.882+0900 E/cluster-home(  599): homescreen-main.cpp: app_pause(355) >  app pause
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 169 331 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 186 387 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 47 595 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 156 623 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 169 651 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 186 707 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] RSSI 0!"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: icon_box_pack(720) > "Pack to FIXED list : RSSI"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
06-11 01:15:11.092+0900 I/EFL-ASSIST(  481): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 562f70 (elm_image), color code: AO004, color [255, 255, 255, 255]
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 169 331 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 186 387 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] RSSI 1!"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: icon_box_pack(720) > "Pack to FIXED list : RSSI"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
06-11 01:15:11.092+0900 I/EFL-ASSIST(  481): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 561810 (elm_image), color code: AO004, color [255, 255, 255, 255]
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 47 595 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 156 623 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 169 651 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-11 01:15:11.092+0900 I/indicator(  481): indicator_box_util.c: _update_display(585) > "Noti Icon : 186 707 5 28 25"
06-11 01:15:24.502+0900 I/CAPI_APPFW_APPLICATION(16643): app_main.c: app_efl_exit(145) > app_efl_exit
06-11 01:15:24.502+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 22
06-11 01:15:24.502+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(803) > app status : 5
06-11 01:15:24.512+0900 I/APP_CORE(16643): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
06-11 01:15:24.512+0900 I/APP_CORE(16643): appcore-efl.c: __after_loop(1059) > [APP 16643] PAUSE before termination
06-11 01:15:24.512+0900 I/CAPI_APPFW_APPLICATION(16643): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-11 01:15:24.512+0900 I/CAPI_APPFW_APPLICATION(16643): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
06-11 01:15:24.542+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 01:15:24.542+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 01:15:24.622+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=599
06-11 01:15:24.642+0900 I/CAPI_APPFW_APPLICATION(  599): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-11 01:15:24.642+0900 E/cluster-home(  599): homescreen-main.cpp: app_resume(422) >  app resume
06-11 01:15:24.702+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 01:15:24.712+0900 I/Tizen::System(  965): (259) > Active app [com.samsun], current [org.tizen.] 
06-11 01:15:24.712+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 01:15:24.722+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 01:15:24.722+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 599"
06-11 01:15:24.812+0900 I/UXT     (16643): uxt_object_manager.cpp: on_terminating(301) > Terminating.
06-11 01:15:24.962+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(142) > dead_pid = 16643 pgid = 16643
06-11 01:15:24.962+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(123) > dead_pid(16643)
06-11 01:15:24.962+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-11 01:15:24.962+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-11 01:15:24.962+0900 I/AUL_AMD (  439): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 16643
06-11 01:15:24.962+0900 I/Tizen::System(  965): (246) > Terminated app [org.tizen.testuicontrolsample]
06-11 01:15:24.962+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 01:15:24.962+0900 I/Tizen::App(  934): (243) > App[org.tizen.testuicontrolsample] pid[16643] terminate event is forwarded
06-11 01:15:24.962+0900 I/Tizen::System(  934): (256) > osp.accessorymanager.service provider is found.
06-11 01:15:24.962+0900 I/Tizen::System(  934): (196) > Accessory Owner is removed [org.tizen.testuicontrolsample, 16643, ]
06-11 01:15:24.962+0900 I/Tizen::System(  934): (256) > osp.system.service provider is found.
06-11 01:15:24.962+0900 I/Tizen::App(  934): (506) > TerminatedApp(org.tizen.testuicontrolsample)
06-11 01:15:24.962+0900 I/Tizen::App(  934): (512) > Not registered pid(16643)
06-11 01:15:24.962+0900 I/Tizen::App(  934): (782) > Finished invoking application event listener for org.tizen.testuicontrolsample, 16643.
06-11 01:15:24.972+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 01:15:24.972+0900 I/Tizen::App(  965): (782) > Finished invoking application event listener for org.tizen.testuicontrolsample, 16643.
06-11 01:15:26.502+0900 W/AUL_AMD (  439): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
06-11 01:15:26.512+0900 W/cluster-view(  599): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
06-11 01:15:27.012+0900 I/MALI    (  599): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8239f88] swap changed from async to sync
06-11 01:15:27.962+0900 I/CAPI_APPFW_APPLICATION( 3957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 01:15:27.962+0900 I/CAPI_APPFW_APPLICATION(  748): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 01:15:27.962+0900 W/CAM_APP ( 3957): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-11 01:15:28.032+0900 I/CAPI_APPFW_APPLICATION(14712): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 01:16:00.002+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb82d46d0]
06-11 01:16:00.002+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:16:00.002+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb82d46d0
06-11 01:16:00.002+0900 E/weather-live(16591): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
06-11 01:16:00.002+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb8478020]
06-11 01:16:00.002+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:16:00.002+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb8478020
06-11 01:16:00.002+0900 E/weather-live(16591): main.c: dynamicbox_update_content(2015) > [0;40;31mFAIL: network request()[0;m
06-11 01:16:00.122+0900 E/weather-live(16591): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-11 01:16:00.142+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-11 01:16:00.142+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-11 01:16:00.172+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb83e6b10]
06-11 01:16:00.172+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:16:00.172+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb83e6b10
06-11 01:16:00.182+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-11 01:16:00.212+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-11 01:16:00.242+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
06-11 01:16:00.262+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
06-11 01:16:00.302+0900 E/weather-live(16591): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-11 01:16:00.312+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-11 01:16:00.312+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-11 01:16:00.332+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb845fa98]
06-11 01:16:00.342+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:16:00.342+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb845fa98
06-11 01:16:00.342+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-11 01:16:00.372+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-11 01:16:00.402+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
06-11 01:16:00.422+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
06-11 01:16:00.452+0900 E/weather-live(16591): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-11 01:16:00.472+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-11 01:16:00.472+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-11 01:16:00.512+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb83ce5e8]
06-11 01:16:00.512+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:16:00.512+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb83ce5e8
06-11 01:16:00.522+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-11 01:16:00.562+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-11 01:16:00.602+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
06-11 01:16:00.642+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
06-11 01:16:00.682+0900 E/weather-common(16591): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
06-11 01:16:00.682+0900 E/weather-common(16591): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
06-11 01:16:00.752+0900 E/cluster-home(  599): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-11 01:16:27.242+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 1
06-11 01:16:27.262+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 01:16:27.262+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 01:16:27.262+0900 W/AUL_AMD (  439): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 1, pid: 14712
06-11 01:16:27.262+0900 W/AUL_AMD (  439): amd_launch.c: _resume_app(728) > resume done
06-11 01:16:27.322+0900 W/AUL_AMD (  439): amd_launch.c: __reply_handler(851) > listen fd(35) , send fd(16), pid(14712), cmd(3)
06-11 01:16:27.442+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=14712
06-11 01:16:27.442+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 01:16:27.452+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.local, pid = 14712"
06-11 01:16:27.492+0900 I/MALI    (  599): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8239f88] swap changed from sync to async
06-11 01:16:27.512+0900 I/CAPI_APPFW_APPLICATION(14712): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-11 01:16:27.512+0900 I/CAPI_APPFW_APPLICATION(  599): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-11 01:16:27.512+0900 E/cluster-home(  599): homescreen-main.cpp: app_pause(355) >  app pause
06-11 01:16:27.542+0900 I/Tizen::System(  965): (259) > Active app [org.tizen.], current [com.samsun] 
06-11 01:16:27.542+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 01:16:27.552+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 01:16:30.402+0900 E/EFL     (14712): elementary<14712> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb8226160 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 01:18:01.542+0900 E/EFL     (14712): elementary<14712> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb82bc258 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 01:19:38.562+0900 E/PKGMGR_SERVER(17804): pkgmgr-server.c: main(1608) > server start
06-11 01:19:38.692+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 01:19:38.692+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 01:19:38.702+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(142) > dead_pid = 14712 pgid = 14712
06-11 01:19:38.702+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(123) > dead_pid(14712)
06-11 01:19:38.702+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-11 01:19:38.702+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-11 01:19:38.712+0900 I/Tizen::System(  965): (246) > Terminated app [org.tizen.local]
06-11 01:19:38.712+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 01:19:38.712+0900 I/Tizen::App(  934): (243) > App[org.tizen.local] pid[14712] terminate event is forwarded
06-11 01:19:38.712+0900 I/Tizen::System(  934): (256) > osp.accessorymanager.service provider is found.
06-11 01:19:38.712+0900 I/Tizen::System(  934): (196) > Accessory Owner is removed [org.tizen.local, 14712, ]
06-11 01:19:38.712+0900 I/Tizen::System(  934): (256) > osp.system.service provider is found.
06-11 01:19:38.712+0900 I/Tizen::App(  934): (506) > TerminatedApp(org.tizen.local)
06-11 01:19:38.712+0900 I/Tizen::App(  934): (512) > Not registered pid(14712)
06-11 01:19:38.712+0900 I/Tizen::App(  934): (782) > Finished invoking application event listener for org.tizen.local, 14712.
06-11 01:19:38.712+0900 I/AUL_AMD (  439): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 14712
06-11 01:19:38.722+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 01:19:38.722+0900 I/Tizen::App(  965): (782) > Finished invoking application event listener for org.tizen.local, 14712.
06-11 01:19:38.752+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 01:19:38.752+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=599
06-11 01:19:38.762+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 599"
06-11 01:19:38.782+0900 I/CAPI_APPFW_APPLICATION(  599): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-11 01:19:38.782+0900 E/cluster-home(  599): homescreen-main.cpp: app_resume(422) >  app resume
06-11 01:19:38.802+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb83b8de8]
06-11 01:19:38.802+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:19:38.802+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb83b8de8
06-11 01:19:38.802+0900 E/weather-live(16591): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
06-11 01:19:38.802+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb849f5d8]
06-11 01:19:38.802+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:19:38.802+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb849f5d8
06-11 01:19:38.802+0900 E/weather-live(16591): main.c: dynamicbox_update_content(2015) > [0;40;31mFAIL: network request()[0;m
06-11 01:19:38.802+0900 I/Tizen::System(  965): (259) > Active app [com.samsun], current [org.tizen.] 
06-11 01:19:38.812+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 01:19:38.822+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 01:19:39.042+0900 E/weather-live(16591): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-11 01:19:39.062+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-11 01:19:39.062+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-11 01:19:39.102+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb84ae718]
06-11 01:19:39.102+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:19:39.102+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb84ae718
06-11 01:19:39.112+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-11 01:19:39.152+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-11 01:19:39.222+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
06-11 01:19:39.262+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
06-11 01:19:39.342+0900 E/weather-live(16591): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-11 01:19:39.352+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-11 01:19:39.352+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-11 01:19:39.392+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb8458488]
06-11 01:19:39.392+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:19:39.392+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb8458488
06-11 01:19:39.422+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-11 01:19:39.462+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-11 01:19:39.502+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
06-11 01:19:39.572+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
06-11 01:19:39.612+0900 E/weather-live(16591): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-11 01:19:39.682+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-11 01:19:39.682+0900 E/weather-live(16591): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-11 01:19:39.742+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_create(363) > New handle created[0xb83d5088]
06-11 01:19:39.742+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_get_type(412) > Connected Network = 0
06-11 01:19:39.742+0900 I/CAPI_NETWORK_CONNECTION(16591): connection.c: connection_destroy(379) > Destroy handle: 0xb83d5088
06-11 01:19:39.762+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-11 01:19:39.842+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-11 01:19:39.882+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
06-11 01:19:39.922+0900 E/weather-common(16591): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
06-11 01:19:39.972+0900 E/weather-common(16591): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
06-11 01:19:39.982+0900 E/weather-common(16591): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
06-11 01:19:40.062+0900 E/cluster-home(  599): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-11 01:19:40.632+0900 E/PKGMGR_SERVER(17804): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-11 01:19:40.632+0900 E/PKGMGR_SERVER(17804): pkgmgr-server.c: main(1704) > package manager server terminated.
06-11 01:19:41.142+0900 I/MALI    (  599): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8239f88] swap changed from async to sync
06-11 01:19:42.572+0900 E/PKGMGR_SERVER(17905): pkgmgr-server.c: main(1608) > server start
06-11 01:19:42.632+0900 E/PKGMGR  (17905): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.local]
06-11 01:19:42.632+0900 E/PKGMGR_SERVER(17905): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.local 
06-11 01:19:42.632+0900 E/PKGMGR_SERVER(17905): [0;m
06-11 01:19:42.802+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: start, val: update
06-11 01:19:42.802+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [start], Value = [update], install = [1]
06-11 01:19:42.812+0900 W/AUL_AMD (  439): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
06-11 01:19:42.812+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 30
06-11 01:19:42.812+0900 I/Tizen::App(  934): (119) > InstallationInProgress [30]
06-11 01:19:42.812+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [30], install = [96]
06-11 01:19:43.482+0900 E/PKGMGR_CERT(17906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-11 01:19:43.482+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 60
06-11 01:19:43.482+0900 I/Tizen::App(  934): (119) > InstallationInProgress [60]
06-11 01:19:43.482+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [60], install = [96]
06-11 01:19:43.492+0900 E/PKGMGR_CERT(17906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 104
06-11 01:19:43.492+0900 E/PKGMGR_CERT(17906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 104
06-11 01:19:43.492+0900 E/PKGMGR_CERT(17906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 30 8
06-11 01:19:43.492+0900 E/PKGMGR_CERT(17906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 18
06-11 01:19:43.492+0900 E/PKGMGR_CERT(17906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 18
06-11 01:19:43.492+0900 E/PKGMGR_CERT(17906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 8
06-11 01:19:43.512+0900 E/PKGMGR_CERT(17906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
06-11 01:19:43.512+0900 E/rpm-installer(17906): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.local/shared], errno=[2][No such file or directory]
06-11 01:19:43.512+0900 E/rpm-installer(17906): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared]
06-11 01:19:43.512+0900 E/rpm-installer(17906): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.local/shared/data]
06-11 01:19:43.512+0900 E/rpm-installer(17906): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared/res]
06-11 01:19:43.512+0900 E/rpm-installer(17906): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.local/tizen-manifest.xml]
06-11 01:19:43.512+0900 E/rpm-installer(17906): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.local/author-signature.xml]
06-11 01:19:43.512+0900 E/rpm-installer(17906): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.local/signature1.xml]
06-11 01:19:43.512+0900 E/rpm-installer(17906): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.local.xml]
06-11 01:19:44.022+0900 E/rpm-installer(17906): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.local/shared/data]))
06-11 01:19:44.632+0900 E/PKGMGR_SERVER(17905): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-11 01:19:44.692+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 100
06-11 01:19:44.692+0900 I/Tizen::App(  934): (119) > InstallationInProgress [100]
06-11 01:19:44.692+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [100], install = [96]
06-11 01:19:44.692+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: end, val: ok
06-11 01:19:44.692+0900 I/Tizen::App(  934): (78) > Installation is Completed. [Package = org.tizen.local]
06-11 01:19:44.692+0900 I/Tizen::App(  934): (663) > Enter. package(org.tizen.local), installationResult(0)
06-11 01:19:44.702+0900 I/Tizen::App(  934): (1360) > package(org.tizen.local), version(1.0.0), type(rpm), displayName(local), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.local), storeClient(), appRootPath(/opt/usr/apps/org.tizen.local)
06-11 01:19:44.712+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
06-11 01:19:44.712+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
06-11 01:19:44.712+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-11 01:19:44.712+0900 E/PKGMGR_INFO(17906): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-11 01:19:44.712+0900 E/PKGMGR_INSTALLER(17906): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-11 01:19:44.762+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.local]
06-11 01:19:44.762+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.local]
06-11 01:19:44.762+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
06-11 01:19:44.762+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
06-11 01:19:44.762+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.local]
06-11 01:19:44.762+0900 I/Tizen::App(  934): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.local]
06-11 01:19:44.772+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-11 01:19:44.772+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-11 01:19:44.782+0900 I/Tizen::App(  934): (416) > appName = [local]
06-11 01:19:44.782+0900 I/Tizen::App(  934): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-11 01:19:44.782+0900 E/PKGMGR_INFO(  934): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-11 01:19:44.782+0900 I/Tizen::App(  934): (675) > Application count(1) in this package
06-11 01:19:44.782+0900 I/Tizen::App(  934): (855) > Enter.
06-11 01:19:44.782+0900 I/Tizen::App(  934): (695) > Exit.
06-11 01:19:44.782+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [end], Value = [ok], install = [96]
06-11 01:19:44.792+0900 I/Tizen::App(  934): (416) > appName = [local]
06-11 01:19:44.792+0900 I/Tizen::App(  934): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-11 01:19:44.792+0900 I/Tizen::App(  934): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.local.info]
06-11 01:19:44.792+0900 I/Tizen::App(  934): (131) > Enter
06-11 01:19:44.802+0900 I/Tizen::App(  934): (137) > org.tizen.local does not have launch condition
06-11 01:19:44.802+0900 I/Tizen::App(  934): (898) > Exit.
06-11 01:19:46.512+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 0
06-11 01:19:46.522+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-11 01:19:46.532+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-11 01:19:46.532+0900 E/AUL_AMD (  439): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-11 01:19:46.602+0900 I/CAPI_APPFW_APPLICATION(17973): app_main.c: ui_app_main(699) > app_efl_main
06-11 01:19:46.632+0900 E/PKGMGR_SERVER(17905): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-11 01:19:46.632+0900 E/PKGMGR_SERVER(17905): pkgmgr-server.c: main(1704) > package manager server terminated.
06-11 01:19:46.652+0900 I/UXT     (17973): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-11 01:19:46.672+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 01:19:46.672+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 01:19:46.672+0900 E/RESOURCED(  773): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 400
06-11 01:19:46.702+0900 I/Tizen::App(  934): (499) > LaunchedApp(org.tizen.local)
06-11 01:19:46.702+0900 I/Tizen::App(  934): (733) > Finished invoking application event listener for org.tizen.local, 17973.
06-11 01:19:46.712+0900 I/Tizen::App(  965): (733) > Finished invoking application event listener for org.tizen.local, 17973.
06-11 01:19:46.722+0900 I/CAPI_APPFW_APPLICATION(17973): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-11 01:19:46.902+0900 E/EFL     (17973): elementary<17973> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb8223b38 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 01:19:46.912+0900 E/EFL     (17973): evas_main<17973> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-11 01:19:46.932+0900 E/EFL     (17973): evas_main<17973> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-11 01:19:46.942+0900 I/CAPI_APPFW_APPLICATION(17973): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-11 01:19:46.962+0900 I/APP_CORE(17973): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-11 01:19:46.962+0900 I/APP_CORE(17973): appcore-efl.c: __do_app(511) > [APP 17973] Initial Launching, call the resume_cb
06-11 01:19:46.962+0900 I/CAPI_APPFW_APPLICATION(17973): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-11 01:19:47.002+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=17973
06-11 01:19:47.032+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 01:19:47.042+0900 W/APP_CORE(17973): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
06-11 01:19:47.042+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.local, pid = 17973"
06-11 01:19:47.062+0900 I/MALI    (  599): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8239f88] swap changed from sync to async
06-11 01:19:47.112+0900 I/Tizen::System(  965): (259) > Active app [org.tizen.], current [com.samsun] 
06-11 01:19:47.112+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 01:19:47.122+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 01:19:47.142+0900 I/CAPI_APPFW_APPLICATION(  599): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-11 01:19:47.142+0900 E/cluster-home(  599): homescreen-main.cpp: app_pause(355) >  app pause
06-11 01:19:47.162+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 01:19:47.162+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 01:19:48.662+0900 E/EFL     (17973): elementary<17973> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb82a6860 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 01:19:49.402+0900 E/EFL     (17973): elementary<17973> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb8224638 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 01:19:49.572+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 01:19:49.572+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 01:19:49.582+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(142) > dead_pid = 17973 pgid = 17973
06-11 01:19:49.582+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(123) > dead_pid(17973)
06-11 01:19:49.582+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-11 01:19:49.582+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-11 01:19:49.592+0900 I/Tizen::System(  965): (246) > Terminated app [org.tizen.local]
06-11 01:19:49.592+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 01:19:49.592+0900 I/Tizen::App(  934): (243) > App[org.tizen.local] pid[17973] terminate event is forwarded
06-11 01:19:49.592+0900 I/Tizen::System(  934): (256) > osp.accessorymanager.service provider is found.
06-11 01:19:49.592+0900 I/Tizen::System(  934): (196) > Accessory Owner is removed [org.tizen.local, 17973, ]
06-11 01:19:49.592+0900 I/Tizen::System(  934): (256) > osp.system.service provider is found.
06-11 01:19:49.592+0900 I/Tizen::App(  934): (506) > TerminatedApp(org.tizen.local)
06-11 01:19:49.592+0900 I/Tizen::App(  934): (512) > Not registered pid(17973)
06-11 01:19:49.592+0900 I/Tizen::App(  934): (782) > Finished invoking application event listener for org.tizen.local, 17973.
06-11 01:19:49.592+0900 I/AUL_AMD (  439): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 17973
06-11 01:19:49.602+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 01:19:49.602+0900 I/Tizen::App(  965): (782) > Finished invoking application event listener for org.tizen.local, 17973.
06-11 01:19:49.602+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 01:19:49.612+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 599"
06-11 01:19:49.662+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=599
06-11 01:19:49.702+0900 I/CAPI_APPFW_APPLICATION(  599): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-11 01:19:49.702+0900 E/cluster-home(  599): homescreen-main.cpp: app_resume(422) >  app resume
06-11 01:19:49.702+0900 W/CRASH_MANAGER(17988): worker.c: worker_job(1236) > 11179736c6f63143395318
