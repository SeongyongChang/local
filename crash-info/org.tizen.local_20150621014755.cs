S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: local
PID: 5826
Date: 2015-06-21 01:47:55+0900
Executable File Path: /opt/usr/apps/org.tizen.local/bin/local
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x78c7c73f

Register Information
r0   = 0x78c7c73f, r1   = 0xb4d9632b
r2   = 0x78c7c73f, r3   = 0x00000000
r4   = 0x78c7c73f, r5   = 0xb4d9632b
r6   = 0x0000003d, r7   = 0x00000001
r8   = 0x0000003e, r9   = 0xb653a4d0
r10  = 0xb4d9632b, fp   = 0xbeda9a9c
ip   = 0xb4d9632c, sp   = 0xbeda9508
lr   = 0x00000049, pc   = 0xb6c9187c
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    143656 KB
Buffers:     39980 KB
Cached:     196680 KB
VmPeak:      82688 KB
VmSize:      82684 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18620 KB
VmRSS:       18616 KB
VmData:      33116 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23768 KB
VmPTE:          58 KB
VmSwap:          0 KB

Maps Information
b447a000 b447f000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/linux-gnueabi-armv7l-1.7.99/module.so
b4487000 b4497000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b4498000 b449d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b4551000 b4552000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b455a000 b4561000 r-xp /usr/lib/libfeedback.so.0.1.4
b4577000 b4578000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b4580000 b4582000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b458a000 b458b000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b4593000 b45aa000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b4706000 b470a000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b4713000 b471d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4966000 b4a30000 r-xp /usr/lib/libCOREGL.so.4.0
b4a41000 b4a46000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4a4e000 b4a50000 r-xp /usr/lib/libiniparser.so.0
b4a5a000 b4b99000 r-xp /usr/lib/libicui18n.so.51.1
b4ba9000 b4bab000 r-xp /usr/lib/libdri2.so.0.0.0
b4bb3000 b4bba000 r-xp /usr/lib/libtbm.so.1.0.0
b4bc2000 b4bc9000 r-xp /usr/lib/libdrm.so.2.4.0
b4bd2000 b4bda000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4be2000 b4be7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4bef000 b4bf4000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4bfd000 b4bfe000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4c07000 b4c1f000 r-xp /usr/lib/libpng12.so.0.50.0
b4c27000 b4c2a000 r-xp /usr/lib/libEGL.so.1.4
b4c32000 b4c40000 r-xp /usr/lib/libGLESv2.so.2.0
b4c49000 b4c4d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4c56000 b4c5e000 r-xp /usr/lib/libui-extension.so.0.1.0
b4c5f000 b4c62000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4c6a000 b4c6d000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4c75000 b4d2b000 r-xp /usr/lib/libcairo.so.2.11200.14
b4d36000 b4d48000 r-xp /usr/lib/libtts.so
b4d50000 b4d66000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4d6e000 b4d75000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4d80000 b4d8a000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4d93000 b4d97000 r-xp /opt/usr/apps/org.tizen.local/bin/local
b4d9f000 b4da9000 r-xp /lib/libnss_files-2.13.so
b4db2000 b4dc4000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4dcc000 b4de2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4dea000 b4eb8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4ecf000 b4ef3000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4efc000 b4f02000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f0a000 b4f18000 r-xp /usr/lib/libail.so.0.1.0
b4f20000 b4f22000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f2b000 b4f30000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f39000 b4f3b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4f43000 b4f44000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f4d000 b4f51000 r-xp /usr/lib/libogg.so.0.7.1
b4f59000 b4f7b000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f83000 b5067000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b507b000 b50ac000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a46000 b5ada000 r-xp /usr/lib/libstdc++.so.6.0.16
b5aed000 b5aef000 r-xp /usr/lib/libXau.so.6.0.0
b5af7000 b5b01000 r-xp /usr/lib/libspdy.so.0.0.0
b5b0a000 b5b56000 r-xp /usr/lib/libssl.so.1.0.0
b5b63000 b5b91000 r-xp /usr/lib/libidn.so.11.5.44
b5b99000 b5ba3000 r-xp /usr/lib/libcares.so.2.1.0
b5bab000 b5bcc000 r-xp /usr/lib/libexif.so.12.3.3
b5bdf000 b5c24000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c32000 b5c48000 r-xp /lib/libexpat.so.1.5.2
b5c51000 b5d36000 r-xp /usr/lib/libicuuc.so.51.1
b5d4b000 b5d7f000 r-xp /usr/lib/libicule.so.51.1
b5d88000 b5d9b000 r-xp /usr/lib/libxcb.so.1.1.0
b5da3000 b5de0000 r-xp /usr/lib/libcurl.so.4.3.0
b5de9000 b5df2000 r-xp /usr/lib/libethumb.so.1.7.99
b5dfb000 b5dfd000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e05000 b5e12000 r-xp /usr/lib/libremix.so.0.0.0
b5e1a000 b5e1b000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e23000 b5e3a000 r-xp /usr/lib/liblua-5.1.so
b5e43000 b5e4a000 r-xp /usr/lib/libembryo.so.1.7.99
b5e52000 b5e75000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e8d000 b5ee3000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5ef0000 b5f43000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f4e000 b5f76000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f77000 b5fbd000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5fc6000 b5fd9000 r-xp /usr/lib/libfribidi.so.0.3.1
b5fe1000 b5fe4000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5fec000 b5ff0000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5ff8000 b5ffd000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6006000 b6010000 r-xp /usr/lib/libXext.so.6.4.0
b6018000 b60f9000 r-xp /usr/lib/libX11.so.6.3.0
b6104000 b6107000 r-xp /usr/lib/libXtst.so.6.1.0
b610f000 b6115000 r-xp /usr/lib/libXrender.so.1.3.0
b611d000 b6122000 r-xp /usr/lib/libXrandr.so.2.2.0
b612a000 b612b000 r-xp /usr/lib/libXinerama.so.1.0.0
b6134000 b613c000 r-xp /usr/lib/libXi.so.6.1.0
b613d000 b6140000 r-xp /usr/lib/libXfixes.so.3.1.0
b6148000 b614a000 r-xp /usr/lib/libXgesture.so.7.0.0
b6152000 b6154000 r-xp /usr/lib/libXcomposite.so.1.0.0
b615c000 b615d000 r-xp /usr/lib/libXdamage.so.1.1.0
b6166000 b616c000 r-xp /usr/lib/libXcursor.so.1.0.2
b6175000 b618e000 r-xp /usr/lib/libecore_con.so.1.7.99
b6198000 b619e000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61a6000 b61ae000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61b6000 b61bf000 r-xp /usr/lib/libedbus.so.1.7.99
b61c7000 b6224000 r-xp /usr/lib/libedje.so.1.7.99
b622d000 b623e000 r-xp /usr/lib/libecore_input.so.1.7.99
b6246000 b624b000 r-xp /usr/lib/libecore_file.so.1.7.99
b6253000 b626c000 r-xp /usr/lib/libeet.so.1.7.99
b627d000 b6281000 r-xp /usr/lib/libappcore-common.so.1.1
b6289000 b6350000 r-xp /usr/lib/libevas.so.1.7.99
b6375000 b6396000 r-xp /usr/lib/libecore_evas.so.1.7.99
b639f000 b63ce000 r-xp /usr/lib/libecore_x.so.1.7.99
b63d8000 b650f000 r-xp /usr/lib/libelementary.so.1.7.99
b6525000 b6526000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b652e000 b6532000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b653d000 b6540000 r-xp /lib/libgpg-error.so.0.5.0
b6548000 b65a0000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65aa000 b65d6000 r-xp /usr/lib/libsystemd.so.0.0.1
b65df000 b65e1000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65ea000 b66b5000 r-xp /usr/lib/libxml2.so.2.7.8
b66c3000 b66d3000 r-xp /lib/libresolv-2.13.so
b66d7000 b66ed000 r-xp /lib/libz.so.1.2.5
b66f5000 b66f7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66ff000 b6704000 r-xp /usr/lib/libffi.so.5.0.10
b670d000 b670e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6716000 b6719000 r-xp /lib/libattr.so.1.1.0
b6721000 b6724000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b672c000 b6733000 r-xp /usr/lib/libvconf.so.0.2.45
b673c000 b68e3000 r-xp /usr/lib/libcrypto.so.1.0.0
b6905000 b691b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6923000 b698c000 r-xp /lib/libm-2.13.so
b6995000 b69d5000 r-xp /usr/lib/libeina.so.1.7.99
b69de000 b6a12000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a1b000 b6aef000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6afb000 b6b00000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b09000 b6b0f000 r-xp /lib/librt-2.13.so
b6b18000 b6b1f000 r-xp /lib/libcrypt-2.13.so
b6b4f000 b6b52000 r-xp /lib/libcap.so.2.21
b6b5a000 b6b5c000 r-xp /usr/lib/libiri.so
b6b64000 b6b83000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b8b000 b6ba1000 r-xp /usr/lib/libecore.so.1.7.99
b6bb7000 b6bbc000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bc5000 b6bdc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6be5000 b6bf0000 r-xp /lib/libunwind.so.8.0.1
b6c1d000 b6d38000 r-xp /lib/libc-2.13.so
b6d46000 b6d4e000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d56000 b6d80000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d89000 b6d8c000 r-xp /usr/lib/libbundle.so.0.1.22
b6d94000 b6d96000 r-xp /lib/libdl-2.13.so
b6d9f000 b6da2000 r-xp /usr/lib/libsmack.so.1.0.0
b6daa000 b6e7a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e7b000 b6ee0000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6eea000 b6efc000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f04000 b6f18000 r-xp /lib/libpthread-2.13.so
b6f23000 b6f25000 r-xp /usr/lib/libdlog.so.0.0.0
b6f2d000 b6f38000 r-xp /usr/lib/libaul.so.0.1.0
b6f4a000 b6f4d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f57000 b6f5b000 r-xp /usr/lib/libsys-assert.so
b6f64000 b6f81000 r-xp /lib/ld-2.13.so
b6f8a000 b6f8f000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7a15000 b7a3f000 rw-p [heap]
b7a3f000 b7e2b000 rw-p [heap]
bed8a000 bedab000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5826)
Call Stack Count: 6
 0: mempcpy + 0x3c (0xb6c9187c) [/lib/libc.so.6] + 0x7487c
 1: _IO_default_xsputn + 0xa4 (0xb6c84c0c) [/lib/libc.so.6] + 0x67c0c
 2: _IO_vfprintf + 0xc8 (0xb6c59f8c) [/lib/libc.so.6] + 0x3cf8c
 3: vsprintf + 0x64 (0xb6c79944) [/lib/libc.so.6] + 0x5c944
 4: sprintf + 0x1c (0xb6c631fc) [/lib/libc.so.6] + 0x461fc
 5: clicked_submit_btn_cb + 0x3c (0xb4d951dd) [/opt/usr/apps/org.tizen.local/bin/local] + 0x21dd
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
00 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:true][0m
06-21 01:36:14.976+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 01:36:14.976+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 01:36:14.976+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 01:36:14.976+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 01:36:14.976+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:1:LOCK
06-21 01:36:14.976+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:1 event_info:0
06-21 01:36:14.976+0900 W/LOCKSCREEN(  562): view-mgr.c: _event_route(108) > [_event_route:108:W] event:1 event_info:0
06-21 01:36:14.996+0900 W/LOCKSCREEN(  562): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1E00008] is now visible(0)
06-21 01:36:14.996+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:10001:WIN_BECOME_VISIBLE
06-21 01:36:14.996+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:10001 event_info:0
06-21 01:36:14.996+0900 I/CAPI_APPFW_APPLICATION(  562): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-21 01:36:14.996+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:20004:APP_RESUME
06-21 01:36:14.996+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:20004 event_info:0
06-21 01:36:15.116+0900 I/Tizen::System(  993): (259) > Active app [com.samsun], current [org.tizen.] 
06-21 01:36:15.116+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 01:36:15.126+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 01:36:15.446+0900 W/LOCKSCREEN(  562): util-daemon.c: _ckmc_lock_timer_cb(183) > [_ckmc_lock_timer_cb:183:W] key manager lock:0
06-21 01:38:17.996+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __alarm_expired(1210) > alarm_id[1497694557] is expired.
06-21 01:38:17.996+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __alarm_remove_from_list(388) > [alarm-server]:Remove alarm id(1497694557)
06-21 01:38:17.996+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __rtc_set(192) > Setted RTC Alarm date/time is 20-6-2015, 17:10:21 (UTC).
06-21 01:38:17.996+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __rtc_set(204) > [alarm-server]RTC alarm is set and it's ON.
06-21 01:38:18.006+0900 W/ALARM_MANAGER(  825): alarm-lib.c: __expire_alarm_filter(141) > [alarm-lib] : Alarm expired for [ALARM.apush] : Alarm id [1497694557]
06-21 01:38:18.026+0900 I/AUL     (  825): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.046+0900 I/AUL     (  825): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.046+0900 W/ALARM_MANAGER(  825): alarm-lib.c: alarmmgr_add_alarm_withcb(1143) > trigger_at_time(15), start(21-6-2015, 01:38:33), repeat(0), interval(0), type(-1073741822)
06-21 01:38:18.056+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.066+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.076+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.086+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.086+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.096+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.096+0900 W/ALARM_MANAGER(  401): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
06-21 01:38:18.096+0900 W/ALARM_MANAGER(  401): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1434818313, Sun Jun 21 01:38:33 2015
06-21 01:38:18.096+0900 W/ALARM_MANAGER(  401): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1636668868, next duetime: 1434818313
06-21 01:38:18.096+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __alarm_add_to_list(309) > [alarm-server]: After add alarm_id(1636668868)
06-21 01:38:18.096+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __alarm_create(860) > [alarm-server]:alarm_context.c_due_time(1434820221), due_time(1434818313)
06-21 01:38:18.096+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __rtc_set(192) > Setted RTC Alarm date/time is 20-6-2015, 16:38:33 (UTC).
06-21 01:38:18.136+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __rtc_set(204) > [alarm-server]RTC alarm is set and it's ON.
06-21 01:38:18.296+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __alarm_remove_from_list(388) > [alarm-server]:Remove alarm id(1636668868)
06-21 01:38:18.306+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __rtc_set(192) > Setted RTC Alarm date/time is 20-6-2015, 17:10:21 (UTC).
06-21 01:38:18.306+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __rtc_set(204) > [alarm-server]RTC alarm is set and it's ON.
06-21 01:38:18.306+0900 E/PUSHD   (  825): ping.c: ping_success(351) > = PING_SUCCESS = avg[240] inc[240] min[240] max[1440] interval[1440] successes[29] max[1] EXLORE[true]
06-21 01:38:18.316+0900 W/ALARM_MANAGER(  401): alarm-manager.c: alarm_manager_alarm_delete(1737) > alarm_id[1636668868] is removed.
06-21 01:38:18.316+0900 I/AUL     (  825): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.326+0900 I/AUL     (  825): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.326+0900 W/ALARM_MANAGER(  825): alarm-lib.c: alarmmgr_add_alarm_withcb(1143) > trigger_at_time(1440), start(21-6-2015, 02:02:18), repeat(0), interval(0), type(-1073741822)
06-21 01:38:18.336+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.346+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.356+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.366+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.366+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.376+0900 I/AUL     (  401): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
06-21 01:38:18.376+0900 W/ALARM_MANAGER(  401): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
06-21 01:38:18.376+0900 W/ALARM_MANAGER(  401): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1434819738, Sun Jun 21 02:02:18 2015
06-21 01:38:18.376+0900 W/ALARM_MANAGER(  401): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1636668868, next duetime: 1434819738
06-21 01:38:18.376+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __alarm_add_to_list(309) > [alarm-server]: After add alarm_id(1636668868)
06-21 01:38:18.376+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __alarm_create(860) > [alarm-server]:alarm_context.c_due_time(1434820221), due_time(1434819738)
06-21 01:38:18.376+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __rtc_set(192) > Setted RTC Alarm date/time is 20-6-2015, 17:02:18 (UTC).
06-21 01:38:18.456+0900 W/ALARM_MANAGER(  401): alarm-manager.c: __rtc_set(204) > [alarm-server]RTC alarm is set and it's ON.
06-21 01:47:15.516+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2045 pgid = 2045
06-21 01:47:15.516+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(123) > dead_pid(2045)
06-21 01:47:15.516+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-21 01:47:15.516+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-21 01:47:15.536+0900 I/Tizen::System(  993): (246) > Terminated app [org.tizen.local]
06-21 01:47:15.536+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 01:47:15.536+0900 I/Tizen::App(  978): (243) > App[org.tizen.local] pid[2045] terminate event is forwarded
06-21 01:47:15.536+0900 I/Tizen::System(  978): (256) > osp.accessorymanager.service provider is found.
06-21 01:47:15.536+0900 I/Tizen::System(  978): (196) > Accessory Owner is removed [org.tizen.local, 2045, ]
06-21 01:47:15.536+0900 I/Tizen::System(  978): (256) > osp.system.service provider is found.
06-21 01:47:15.536+0900 I/Tizen::App(  978): (506) > TerminatedApp(org.tizen.local)
06-21 01:47:15.536+0900 I/Tizen::App(  978): (512) > Not registered pid(2045)
06-21 01:47:15.536+0900 I/Tizen::App(  978): (782) > Finished invoking application event listener for org.tizen.local, 2045.
06-21 01:47:15.536+0900 I/AUL_AMD (  447): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 2045
06-21 01:47:15.546+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 01:47:15.546+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 01:47:15.556+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 01:47:15.556+0900 I/Tizen::App(  993): (782) > Finished invoking application event listener for org.tizen.local, 2045.
06-21 01:47:19.256+0900 E/PKGMGR  ( 5508): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.local]
06-21 01:47:19.256+0900 E/PKGMGR_SERVER( 5508): pkgmgr-server.c: __get_type_from_msg(283) > [0;31m[__get_type_from_msg(): 283](pkgtype == NULL) pkgtype is null for org.tizen.local 
06-21 01:47:19.256+0900 E/PKGMGR_SERVER( 5508): [0;m
06-21 01:47:19.426+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: start, val: update
06-21 01:47:19.426+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [start], Value = [update], install = [1]
06-21 01:47:19.436+0900 W/AUL_AMD (  447): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
06-21 01:47:19.436+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 30
06-21 01:47:19.436+0900 I/Tizen::App(  978): (119) > InstallationInProgress [30]
06-21 01:47:19.436+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [30], install = [1]
06-21 01:47:20.106+0900 E/PKGMGR_CERT( 5509): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-21 01:47:20.116+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 60
06-21 01:47:20.116+0900 I/Tizen::App(  978): (119) > InstallationInProgress [60]
06-21 01:47:20.116+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [60], install = [1]
06-21 01:47:20.116+0900 E/PKGMGR_CERT( 5509): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 87
06-21 01:47:20.116+0900 E/PKGMGR_CERT( 5509): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 87
06-21 01:47:20.116+0900 E/PKGMGR_CERT( 5509): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 1
06-21 01:47:20.116+0900 E/PKGMGR_CERT( 5509): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 1
06-21 01:47:20.116+0900 E/PKGMGR_CERT( 5509): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 1
06-21 01:47:20.116+0900 E/PKGMGR_CERT( 5509): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 1
06-21 01:47:20.136+0900 E/PKGMGR_CERT( 5509): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
06-21 01:47:20.136+0900 E/rpm-installer( 5509): coretpk-installer.c: _coretpk_installer_make_directory(1784) > mkdir failed. appdir=[/usr/apps/org.tizen.local/shared], errno=[2][No such file or directory]
06-21 01:47:20.136+0900 E/rpm-installer( 5509): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared]
06-21 01:47:20.136+0900 E/rpm-installer( 5509): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/opt/usr/apps/org.tizen.local/shared/data]
06-21 01:47:20.136+0900 E/rpm-installer( 5509): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared/res]
06-21 01:47:20.136+0900 E/rpm-installer( 5509): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/tizen-manifest.xml]
06-21 01:47:20.136+0900 E/rpm-installer( 5509): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/author-signature.xml]
06-21 01:47:20.136+0900 E/rpm-installer( 5509): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/signature1.xml]
06-21 01:47:20.136+0900 E/rpm-installer( 5509): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/share/packages/org.tizen.local.xml]
06-21 01:47:21.266+0900 E/rpm-installer( 5509): coretpk-installer.c: _coretpk_installer_get_smack_label_access(964) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.local/shared/data]))
06-21 01:47:21.896+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 100
06-21 01:47:21.896+0900 I/Tizen::App(  978): (119) > InstallationInProgress [100]
06-21 01:47:21.896+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [100], install = [1]
06-21 01:47:21.906+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: end, val: ok
06-21 01:47:21.906+0900 I/Tizen::App(  978): (78) > Installation is Completed. [Package = org.tizen.local]
06-21 01:47:21.906+0900 I/Tizen::App(  978): (663) > Enter. package(org.tizen.local), installationResult(0)
06-21 01:47:21.916+0900 I/Tizen::App(  978): (1360) > package(org.tizen.local), version(1.0.0), type(rpm), displayName(local), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.local), storeClient(), appRootPath(/opt/usr/apps/org.tizen.local)
06-21 01:47:21.926+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: OnClientListenCb(535) >  #Step 1
06-21 01:47:21.926+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 2
06-21 01:47:21.926+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-21 01:47:21.966+0900 E/PKGMGR_INFO( 5509): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-21 01:47:21.966+0900 E/PKGMGR_INSTALLER( 5509): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-21 01:47:22.036+0900 I/Tizen::App(  978): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.local]
06-21 01:47:22.036+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.local]
06-21 01:47:22.036+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(365) >  ##### [org.tizen.local]
06-21 01:47:22.036+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(369) >  END
06-21 01:47:22.036+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _DoPkgJob(448) >  #Step 3 size[1]
06-21 01:47:22.036+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _DoPkgJob(452) >  appId[org.tizen.local]
06-21 01:47:22.056+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppInfo(941) >  AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-21 01:47:22.056+0900 I/Tizen::App(  978): (416) > appName = [local]
06-21 01:47:22.056+0900 I/Tizen::App(  978): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-21 01:47:22.056+0900 E/PKGMGR_INFO(  978): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-21 01:47:22.056+0900 I/Tizen::App(  978): (675) > Application count(1) in this package
06-21 01:47:22.056+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: GetAppInfo(595) >  Find a App Info AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-21 01:47:22.056+0900 I/Tizen::App(  978): (695) > Exit.
06-21 01:47:22.056+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [end], Value = [ok], install = [96]
06-21 01:47:22.056+0900 I/Tizen::App(  978): (855) > Enter.
06-21 01:47:22.066+0900 I/Tizen::App(  978): (416) > appName = [local]
06-21 01:47:22.066+0900 I/Tizen::App(  978): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-21 01:47:22.066+0900 I/Tizen::App(  978): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.local.info]
06-21 01:47:22.066+0900 I/Tizen::App(  978): (131) > Enter
06-21 01:47:22.066+0900 I/Tizen::App(  978): (137) > org.tizen.local does not have launch condition
06-21 01:47:22.066+0900 I/Tizen::App(  978): (898) > Exit.
06-21 01:47:23.896+0900 W/AUL_AMD (  447): amd_request.c: __request_handler(601) > __request_handler: 0
06-21 01:47:23.906+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-21 01:47:23.916+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-21 01:47:23.916+0900 E/AUL_AMD (  447): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-21 01:47:23.996+0900 I/CAPI_APPFW_APPLICATION( 5575): app_main.c: ui_app_main(699) > app_efl_main
06-21 01:47:24.036+0900 I/UXT     ( 5575): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-21 01:47:24.056+0900 E/RESOURCED(  758): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 400
06-21 01:47:24.066+0900 I/Tizen::App(  993): (733) > Finished invoking application event listener for org.tizen.local, 5575.
06-21 01:47:24.066+0900 I/Tizen::App(  978): (499) > LaunchedApp(org.tizen.local)
06-21 01:47:24.066+0900 I/Tizen::App(  978): (733) > Finished invoking application event listener for org.tizen.local, 5575.
06-21 01:47:24.096+0900 I/CAPI_APPFW_APPLICATION( 5575): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-21 01:47:24.296+0900 E/EFL     ( 5575): elementary<5575> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b88e48 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 01:47:24.316+0900 E/EFL     ( 5575): evas_main<5575> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-21 01:47:24.326+0900 E/EFL     ( 5575): evas_main<5575> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-21 01:47:24.346+0900 I/CAPI_APPFW_APPLICATION( 5575): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-21 01:47:24.356+0900 I/APP_CORE( 5575): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-21 01:47:24.356+0900 I/APP_CORE( 5575): appcore-efl.c: __do_app(511) > [APP 5575] Initial Launching, call the resume_cb
06-21 01:47:24.356+0900 I/CAPI_APPFW_APPLICATION( 5575): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-21 01:47:24.396+0900 W/APP_CORE( 5575): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4400002
06-21 01:47:24.496+0900 I/CAPI_APPFW_APPLICATION( 5575): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-21 01:47:25.036+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 01:47:25.036+0900 W/AUL_AMD (  447): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
06-21 01:47:36.786+0900 W/LOCKSCREEN(  562): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
06-21 01:47:36.786+0900 W/LOCKSCREEN(  562): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
06-21 01:47:36.786+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:30001:LCD_ON
06-21 01:47:36.786+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:30001 event_info:0
06-21 01:47:36.786+0900 W/LOCKSCREEN(  562): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
06-21 01:47:36.786+0900 W/LOCKSCREEN(  562): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
06-21 01:47:36.786+0900 I/indicator(  473): indicator_ui.c: on_changed_receive(1388) > "LCD On handling"
06-21 01:47:36.786+0900 E/LOCKSCREEN(  562): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
06-21 01:47:36.806+0900 W/LOCKSCREEN(  562): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
06-21 01:47:36.816+0900 W/LOCKSCREEN(  562): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
06-21 01:47:36.816+0900 W/LOCKSCREEN(  562): daemon.c: _lcd_timeout_timer_set(611) > [_lcd_timeout_timer_set:611:W] lcd off timer set:30.000000
06-21 01:47:36.826+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-21 01:47:36.826+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-21 01:47:36.826+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-21 01:47:36.826+0900 I/indicator(  473): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-21 01:47:36.826+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-21 01:47:36.826+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 3 331 5 28 25"
06-21 01:47:36.826+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 10 387 5 28 25"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 1 595 5 28 25"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 2 623 5 28 25"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 3 651 5 28 25"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-21 01:47:36.836+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 10 707 5 28 25"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 3 331 5 28 25"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 10 387 5 28 25"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 1 595 5 28 25"
06-21 01:47:36.846+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 2 623 5 28 25"
06-21 01:47:36.856+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 3 651 5 28 25"
06-21 01:47:36.856+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-21 01:47:36.856+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 10 707 5 28 25"
06-21 01:47:37.456+0900 I/Tizen::System(  993): (280) > The screen has been turned on.
06-21 01:47:37.456+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 01:47:37.456+0900 W/CAM_APP (17509): cam_app.c: __cam_app_display_state_changed_cb(7902) > [33mapp state is PRELAUNCH. ignore this[0m
06-21 01:47:37.476+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 01:47:37.796+0900 E/LOCKSCREEN(  562): progress_circle.c: unlock_mouse_up(276) > 
06-21 01:47:37.796+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:80001:VIEW_GESTURED
06-21 01:47:37.796+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:80001 event_info:0
06-21 01:47:37.796+0900 W/LOCKSCREEN(  562): daemon.c: _lcd_timeout_timer_unset(620) > [_lcd_timeout_timer_unset:620:W] lcd off timer unset
06-21 01:47:37.796+0900 W/LOCKSCREEN(  562): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
06-21 01:47:37.796+0900 W/LOCKSCREEN(  562): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
06-21 01:47:37.796+0900 W/LOCKSCREEN(  562): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
06-21 01:47:37.796+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event_delay(915) > [lockd_event_delay:915:W] dealyed event:2:UNLOCK wait for:0.500000
06-21 01:47:38.306+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:2 event_info:0
06-21 01:47:38.306+0900 W/LOCKSCREEN(  562): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
06-21 01:47:38.306+0900 W/LOCKSCREEN(  562): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
06-21 01:47:38.316+0900 E/WALLPAPER_SERVICE_COMMON(  562): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
06-21 01:47:38.316+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5575
06-21 01:47:38.326+0900 I/CAPI_APPFW_APPLICATION( 5575): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-21 01:47:38.376+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 01:47:38.376+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 01:47:38.376+0900 I/Tizen::System(  993): (259) > Active app [org.tizen.], current [com.samsun] 
06-21 01:47:38.376+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 01:47:38.376+0900 W/LOCKSCREEN(  562): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1E00008] is now visible(1)
06-21 01:47:38.376+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:10002:WIN_BECOME_INVISIBLE
06-21 01:47:38.376+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:10002 event_info:0
06-21 01:47:38.376+0900 I/CAPI_APPFW_APPLICATION(  562): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-21 01:47:38.376+0900 E/LOCKSCREEN(  562): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
06-21 01:47:38.376+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:20002:APP_PAUSE
06-21 01:47:38.376+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:20002 event_info:0
06-21 01:47:38.396+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 01:47:38.526+0900 W/LOCKSCREEN(  562): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
06-21 01:47:38.526+0900 E/LOCKSCREEN(  562): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
06-21 01:47:38.526+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:80000:VIEW_IDLE
06-21 01:47:38.526+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:80000 event_info:0
06-21 01:47:38.536+0900 E/LOCKSCREEN(  562): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
06-21 01:47:38.976+0900 W/LOCKSCREEN(  562): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
06-21 01:47:40.846+0900 E/EFL     ( 5575): elementary<5575> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7bef230 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 01:47:41.376+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(142) > dead_pid = 5575 pgid = 5575
06-21 01:47:41.376+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(123) > dead_pid(5575)
06-21 01:47:41.376+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-21 01:47:41.376+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-21 01:47:41.386+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 01:47:41.386+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 01:47:41.396+0900 I/Tizen::System(  993): (246) > Terminated app [org.tizen.local]
06-21 01:47:41.396+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 01:47:41.406+0900 I/Tizen::App(  978): (243) > App[org.tizen.local] pid[5575] terminate event is forwarded
06-21 01:47:41.406+0900 I/Tizen::System(  978): (256) > osp.accessorymanager.service provider is found.
06-21 01:47:41.406+0900 I/Tizen::System(  978): (196) > Accessory Owner is removed [org.tizen.local, 5575, ]
06-21 01:47:41.406+0900 I/Tizen::System(  978): (256) > osp.system.service provider is found.
06-21 01:47:41.406+0900 I/Tizen::App(  978): (506) > TerminatedApp(org.tizen.local)
06-21 01:47:41.406+0900 I/Tizen::App(  978): (512) > Not registered pid(5575)
06-21 01:47:41.406+0900 I/Tizen::App(  978): (782) > Finished invoking application event listener for org.tizen.local, 5575.
06-21 01:47:41.406+0900 I/AUL_AMD (  447): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 5575
06-21 01:47:41.416+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 01:47:41.416+0900 I/Tizen::App(  993): (782) > Finished invoking application event listener for org.tizen.local, 5575.
06-21 01:47:41.436+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-21 01:47:41.456+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-21 01:47:41.456+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-21 01:47:41.486+0900 I/Tizen::System(  993): (259) > Active app [com.samsun], current [org.tizen.] 
06-21 01:47:41.486+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 01:47:41.496+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 01:47:43.816+0900 I/MALI    (  621): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb20362b8] swap changed from async to sync
06-21 01:47:44.596+0900 E/PKGMGR  ( 5760): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.local]
06-21 01:47:44.596+0900 E/PKGMGR_SERVER( 5760): pkgmgr-server.c: __get_type_from_msg(283) > [0;31m[__get_type_from_msg(): 283](pkgtype == NULL) pkgtype is null for org.tizen.local 
06-21 01:47:44.596+0900 E/PKGMGR_SERVER( 5760): [0;m
06-21 01:47:44.766+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: start, val: update
06-21 01:47:44.766+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [start], Value = [update], install = [1]
06-21 01:47:44.776+0900 W/AUL_AMD (  447): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
06-21 01:47:45.036+0900 I/CAPI_APPFW_APPLICATION(17509): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 01:47:45.036+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 01:47:45.036+0900 W/CAM_APP (17509): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 01:47:45.326+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 30
06-21 01:47:45.326+0900 I/Tizen::App(  978): (119) > InstallationInProgress [30]
06-21 01:47:45.326+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [30], install = [1]
06-21 01:47:46.046+0900 E/PKGMGR_CERT( 5762): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-21 01:47:46.056+0900 E/PKGMGR_CERT( 5762): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 87
06-21 01:47:46.056+0900 E/PKGMGR_CERT( 5762): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 87
06-21 01:47:46.056+0900 E/PKGMGR_CERT( 5762): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 1
06-21 01:47:46.056+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 60
06-21 01:47:46.056+0900 I/Tizen::App(  978): (119) > InstallationInProgress [60]
06-21 01:47:46.056+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [60], install = [1]
06-21 01:47:46.056+0900 E/PKGMGR_CERT( 5762): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 1
06-21 01:47:46.056+0900 E/PKGMGR_CERT( 5762): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 1
06-21 01:47:46.056+0900 E/PKGMGR_CERT( 5762): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 1
06-21 01:47:46.076+0900 E/PKGMGR_CERT( 5762): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
06-21 01:47:46.076+0900 E/rpm-installer( 5762): coretpk-installer.c: _coretpk_installer_make_directory(1784) > mkdir failed. appdir=[/usr/apps/org.tizen.local/shared], errno=[2][No such file or directory]
06-21 01:47:46.076+0900 E/rpm-installer( 5762): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared]
06-21 01:47:46.076+0900 E/rpm-installer( 5762): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/opt/usr/apps/org.tizen.local/shared/data]
06-21 01:47:46.076+0900 E/rpm-installer( 5762): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared/res]
06-21 01:47:46.076+0900 E/rpm-installer( 5762): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/tizen-manifest.xml]
06-21 01:47:46.076+0900 E/rpm-installer( 5762): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/author-signature.xml]
06-21 01:47:46.076+0900 E/rpm-installer( 5762): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/signature1.xml]
06-21 01:47:46.076+0900 E/rpm-installer( 5762): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/share/packages/org.tizen.local.xml]
06-21 01:47:46.526+0900 E/rpm-installer( 5762): coretpk-installer.c: _coretpk_installer_get_smack_label_access(964) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.local/shared/data]))
06-21 01:47:47.146+0900 E/PKGMGR_INFO( 5762): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-21 01:47:47.146+0900 E/PKGMGR_INSTALLER( 5762): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-21 01:47:47.186+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: OnClientListenCb(535) >  #Step 1
06-21 01:47:47.186+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 2
06-21 01:47:47.186+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-21 01:47:47.186+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 100
06-21 01:47:47.186+0900 I/Tizen::App(  978): (119) > InstallationInProgress [100]
06-21 01:47:47.186+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [100], install = [1]
06-21 01:47:47.186+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: end, val: ok
06-21 01:47:47.186+0900 I/Tizen::App(  978): (78) > Installation is Completed. [Package = org.tizen.local]
06-21 01:47:47.186+0900 I/Tizen::App(  978): (663) > Enter. package(org.tizen.local), installationResult(0)
06-21 01:47:47.196+0900 I/Tizen::App(  978): (1360) > package(org.tizen.local), version(1.0.0), type(rpm), displayName(local), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.local), storeClient(), appRootPath(/opt/usr/apps/org.tizen.local)
06-21 01:47:47.216+0900 I/Tizen::App(  978): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.local]
06-21 01:47:47.236+0900 I/Tizen::App(  978): (416) > appName = [local]
06-21 01:47:47.236+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.local]
06-21 01:47:47.236+0900 I/Tizen::App(  978): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-21 01:47:47.236+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(365) >  ##### [org.tizen.local]
06-21 01:47:47.236+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(369) >  END
06-21 01:47:47.236+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _DoPkgJob(448) >  #Step 3 size[1]
06-21 01:47:47.236+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _DoPkgJob(452) >  appId[org.tizen.local]
06-21 01:47:47.236+0900 E/PKGMGR_INFO(  978): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-21 01:47:47.236+0900 I/Tizen::App(  978): (675) > Application count(1) in this package
06-21 01:47:47.236+0900 I/Tizen::App(  978): (855) > Enter.
06-21 01:47:47.246+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppInfo(941) >  AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-21 01:47:47.246+0900 I/Tizen::App(  978): (695) > Exit.
06-21 01:47:47.246+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [end], Value = [ok], install = [1]
06-21 01:47:47.246+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: GetAppInfo(595) >  Find a App Info AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-21 01:47:47.246+0900 I/Tizen::App(  978): (416) > appName = [local]
06-21 01:47:47.246+0900 I/Tizen::App(  978): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-21 01:47:47.246+0900 I/Tizen::App(  978): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.local.info]
06-21 01:47:47.246+0900 I/Tizen::App(  978): (131) > Enter
06-21 01:47:47.256+0900 I/Tizen::App(  978): (137) > org.tizen.local does not have launch condition
06-21 01:47:47.256+0900 I/Tizen::App(  978): (898) > Exit.
06-21 01:47:48.946+0900 W/AUL_AMD (  447): amd_request.c: __request_handler(601) > __request_handler: 0
06-21 01:47:48.956+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-21 01:47:48.966+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-21 01:47:48.966+0900 E/AUL_AMD (  447): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-21 01:47:48.996+0900 I/CAPI_APPFW_APPLICATION(17509): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 01:47:48.996+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 01:47:48.996+0900 W/CAM_APP (17509): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 01:47:49.056+0900 I/CAPI_APPFW_APPLICATION(17509): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 01:47:49.056+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 01:47:49.056+0900 I/CAPI_APPFW_APPLICATION( 5826): app_main.c: ui_app_main(699) > app_efl_main
06-21 01:47:49.056+0900 W/CAM_APP (17509): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 01:47:49.086+0900 E/RESOURCED(  758): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 399
06-21 01:47:49.096+0900 I/UXT     ( 5826): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-21 01:47:49.136+0900 I/Tizen::App(  978): (499) > LaunchedApp(org.tizen.local)
06-21 01:47:49.136+0900 I/Tizen::App(  993): (733) > Finished invoking application event listener for org.tizen.local, 5826.
06-21 01:47:49.176+0900 I/Tizen::App(  978): (733) > Finished invoking application event listener for org.tizen.local, 5826.
06-21 01:47:49.186+0900 I/CAPI_APPFW_APPLICATION( 5826): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-21 01:47:49.386+0900 E/EFL     ( 5826): elementary<5826> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b88e48 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 01:47:49.396+0900 E/EFL     ( 5826): evas_main<5826> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-21 01:47:49.406+0900 E/EFL     ( 5826): evas_main<5826> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-21 01:47:49.426+0900 I/CAPI_APPFW_APPLICATION( 5826): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-21 01:47:49.436+0900 I/APP_CORE( 5826): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-21 01:47:49.436+0900 I/APP_CORE( 5826): appcore-efl.c: __do_app(511) > [APP 5826] Initial Launching, call the resume_cb
06-21 01:47:49.436+0900 I/CAPI_APPFW_APPLICATION( 5826): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-21 01:47:49.476+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5826
06-21 01:47:49.526+0900 W/APP_CORE( 5826): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4400002
06-21 01:47:49.546+0900 I/MALI    (  621): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb20362b8] swap changed from sync to async
06-21 01:47:49.586+0900 I/Tizen::System(  993): (259) > Active app [org.tizen.], current [com.samsun] 
06-21 01:47:49.586+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 01:47:49.596+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 01:47:49.646+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-21 01:47:49.646+0900 E/cluster-home(  621): homescreen-main.cpp: app_pause(355) >  app pause
06-21 01:47:49.656+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 01:47:49.656+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 01:47:52.226+0900 E/EFL     ( 5826): elementary<5826> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7c4e290 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 01:47:53.976+0900 E/EFL     ( 5826): elementary<5826> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b8b208 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 01:47:55.246+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 01:47:55.246+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 01:47:55.276+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(142) > dead_pid = 5826 pgid = 5826
06-21 01:47:55.276+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(123) > dead_pid(5826)
06-21 01:47:55.276+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-21 01:47:55.276+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-21 01:47:55.306+0900 I/Tizen::System(  993): (246) > Terminated app [org.tizen.local]
06-21 01:47:55.306+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 01:47:55.306+0900 I/Tizen::App(  978): (243) > App[org.tizen.local] pid[5826] terminate event is forwarded
06-21 01:47:55.306+0900 I/Tizen::System(  978): (256) > osp.accessorymanager.service provider is found.
06-21 01:47:55.306+0900 I/Tizen::System(  978): (196) > Accessory Owner is removed [org.tizen.local, 5826, ]
06-21 01:47:55.306+0900 I/Tizen::System(  978): (256) > osp.system.service provider is found.
06-21 01:47:55.306+0900 I/Tizen::App(  978): (506) > TerminatedApp(org.tizen.local)
06-21 01:47:55.306+0900 I/Tizen::App(  978): (512) > Not registered pid(5826)
06-21 01:47:55.306+0900 I/Tizen::App(  978): (782) > Finished invoking application event listener for org.tizen.local, 5826.
06-21 01:47:55.306+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-21 01:47:55.306+0900 I/AUL_AMD (  447): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 5826
06-21 01:47:55.326+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 01:47:55.326+0900 I/Tizen::App(  993): (782) > Finished invoking application event listener for org.tizen.local, 5826.
06-21 01:47:55.336+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-21 01:47:55.336+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-21 01:47:55.396+0900 I/Tizen::System(  993): (259) > Active app [com.samsun], current [org.tizen.] 
06-21 01:47:55.396+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 01:47:55.406+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 01:47:55.456+0900 W/CRASH_MANAGER( 5852): worker.c: worker_job(1198) > 11058266c6f63143481887
