S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: local
PID: 4052
Date: 2015-06-11 03:58:01+0900
Executable File Path: /opt/usr/apps/org.tizen.local/bin/local
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x296c

Register Information
r0   = 0x0000296d, r1   = 0x0000296c
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb4f343e1
r6   = 0xbee1aa10, r7   = 0x0000296d
r8   = 0x00000000, r9   = 0xb65344d0
r10  = 0xb4f343e0, fp   = 0xbee1aa04
ip   = 0x00000000, sp   = 0xbee1a4a0
lr   = 0xb6c565b8, pc   = 0xb6c89d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    199264 KB
Buffers:     37576 KB
Cached:     152368 KB
VmPeak:      52424 KB
VmSize:      52420 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15032 KB
VmRSS:       15028 KB
VmData:       5532 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23664 KB
VmPTE:          48 KB
VmSwap:          0 KB

Maps Information
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
b80f2000 b82da000 rw-p [heap]
bedfb000 bee1c000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4052)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6c89d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6c565b8) [/lib/libc.so.6] + 0x3f5b8
 2: vsprintf + 0x64 (0xb6c73944) [/lib/libc.so.6] + 0x5c944
 3: sprintf + 0x1c (0xb6c5d1fc) [/lib/libc.so.6] + 0x461fc
 4: set_calendar_view + 0xf0 (0xb4f3343d) [/opt/usr/apps/org.tizen.local/bin/local] + 0x143d
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
er(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-11 03:52:52.632+0900 E/PKGMGR_SERVER( 2370): pkgmgr-server.c: main(1704) > package manager server terminated.
06-11 03:52:53.182+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 0
06-11 03:52:53.192+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-11 03:52:53.192+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-11 03:52:53.192+0900 E/AUL_AMD (  439): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-11 03:52:53.272+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: ui_app_main(699) > app_efl_main
06-11 03:52:53.312+0900 I/UXT     ( 2443): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-11 03:52:53.332+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 03:52:53.332+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 03:52:53.332+0900 E/RESOURCED(  773): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 385
06-11 03:52:53.342+0900 I/Tizen::App(  965): (733) > Finished invoking application event listener for org.tizen.local, 2443.
06-11 03:52:53.352+0900 I/Tizen::App(  934): (499) > LaunchedApp(org.tizen.local)
06-11 03:52:53.352+0900 I/Tizen::App(  934): (733) > Finished invoking application event listener for org.tizen.local, 2443.
06-11 03:52:53.362+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-11 03:52:53.552+0900 E/EFL     ( 2443): elementary<2443> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb8223b38 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 03:52:53.562+0900 E/EFL     ( 2443): evas_main<2443> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-11 03:52:53.582+0900 E/EFL     ( 2443): evas_main<2443> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-11 03:52:53.592+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-11 03:52:53.602+0900 I/APP_CORE( 2443): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-11 03:52:53.602+0900 I/APP_CORE( 2443): appcore-efl.c: __do_app(511) > [APP 2443] Initial Launching, call the resume_cb
06-11 03:52:53.602+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-11 03:52:53.642+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2443
06-11 03:52:53.652+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 03:52:53.662+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.local, pid = 2443"
06-11 03:52:53.692+0900 W/APP_CORE( 2443): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
06-11 03:52:53.752+0900 I/Tizen::System(  965): (259) > Active app [org.tizen.], current [org.tizen.] 
06-11 03:52:53.752+0900 I/Tizen::System(  965): (273) > Current App[org.tizen.] is already actived.
06-11 03:52:53.822+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 03:52:53.822+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 03:52:53.822+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-11 03:52:56.382+0900 E/EFL     ( 2443): elementary<2443> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb82e9380 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 03:53:49.472+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:49.472+0900 I/CAPI_APPFW_APPLICATION( 3957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:49.472+0900 I/CAPI_APPFW_APPLICATION(  748): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:49.472+0900 W/CAM_APP ( 3957): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-11 03:53:49.542+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:49.542+0900 I/CAPI_APPFW_APPLICATION(29441): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:54.752+0900 I/CAPI_APPFW_APPLICATION( 3957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:54.752+0900 I/CAPI_APPFW_APPLICATION(  748): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:54.752+0900 W/CAM_APP ( 3957): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-11 03:53:54.752+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:54.822+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:54.822+0900 I/CAPI_APPFW_APPLICATION(29441): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.132+0900 I/CAPI_APPFW_APPLICATION( 3957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.132+0900 I/CAPI_APPFW_APPLICATION(  748): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.132+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.132+0900 W/CAM_APP ( 3957): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-11 03:53:56.192+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.192+0900 I/CAPI_APPFW_APPLICATION( 3957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.192+0900 I/CAPI_APPFW_APPLICATION(  748): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.192+0900 W/CAM_APP ( 3957): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-11 03:53:56.202+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.202+0900 I/CAPI_APPFW_APPLICATION(29441): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.252+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.252+0900 I/CAPI_APPFW_APPLICATION( 3957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.252+0900 I/CAPI_APPFW_APPLICATION(  748): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.252+0900 W/CAM_APP ( 3957): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-11 03:53:56.312+0900 I/CAPI_APPFW_APPLICATION( 2443): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.312+0900 I/CAPI_APPFW_APPLICATION( 3957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.312+0900 I/CAPI_APPFW_APPLICATION(  748): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.312+0900 W/CAM_APP ( 3957): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-11 03:53:56.342+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.342+0900 I/CAPI_APPFW_APPLICATION(29441): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.472+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.472+0900 I/CAPI_APPFW_APPLICATION(29441): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.602+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:53:56.602+0900 I/CAPI_APPFW_APPLICATION(29441): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-11 03:54:46.132+0900 E/PKGMGR_SERVER( 2940): pkgmgr-server.c: main(1608) > server start
06-11 03:54:46.242+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2443 pgid = 2443
06-11 03:54:46.242+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(123) > dead_pid(2443)
06-11 03:54:46.242+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-11 03:54:46.242+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-11 03:54:46.282+0900 I/Tizen::System(  965): (246) > Terminated app [org.tizen.local]
06-11 03:54:46.282+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 03:54:46.282+0900 I/Tizen::App(  934): (243) > App[org.tizen.local] pid[2443] terminate event is forwarded
06-11 03:54:46.282+0900 I/Tizen::System(  934): (256) > osp.accessorymanager.service provider is found.
06-11 03:54:46.282+0900 I/Tizen::System(  934): (196) > Accessory Owner is removed [org.tizen.local, 2443, ]
06-11 03:54:46.282+0900 I/Tizen::System(  934): (256) > osp.system.service provider is found.
06-11 03:54:46.282+0900 I/Tizen::App(  934): (506) > TerminatedApp(org.tizen.local)
06-11 03:54:46.282+0900 I/Tizen::App(  934): (512) > Not registered pid(2443)
06-11 03:54:46.282+0900 I/Tizen::App(  934): (782) > Finished invoking application event listener for org.tizen.local, 2443.
06-11 03:54:46.292+0900 I/AUL_AMD (  439): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 2443
06-11 03:54:46.302+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 03:54:46.302+0900 I/Tizen::App(  965): (782) > Finished invoking application event listener for org.tizen.local, 2443.
06-11 03:54:46.312+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 03:54:46.312+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 03:54:46.312+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 03:54:46.322+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8466
06-11 03:54:46.322+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.testuicontrolsample, pid = 8466"
06-11 03:54:46.362+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-11 03:54:46.362+0900 I/Tizen::System(  965): (259) > Active app [org.tizen.], current [org.tizen.] 
06-11 03:54:46.362+0900 I/Tizen::System(  965): (273) > Current App[org.tizen.] is already actived.
06-11 03:54:48.632+0900 E/PKGMGR_SERVER( 2940): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-11 03:54:48.632+0900 E/PKGMGR_SERVER( 2940): pkgmgr-server.c: main(1704) > package manager server terminated.
06-11 03:54:49.602+0900 E/PKGMGR_SERVER( 3040): pkgmgr-server.c: main(1608) > server start
06-11 03:54:49.662+0900 E/PKGMGR  ( 3040): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.local]
06-11 03:54:49.662+0900 E/PKGMGR_SERVER( 3040): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.local 
06-11 03:54:49.662+0900 E/PKGMGR_SERVER( 3040): [0;m
06-11 03:54:49.832+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: start, val: update
06-11 03:54:49.832+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [start], Value = [update], install = [1]
06-11 03:54:49.842+0900 W/AUL_AMD (  439): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
06-11 03:54:49.842+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 30
06-11 03:54:49.842+0900 I/Tizen::App(  934): (119) > InstallationInProgress [30]
06-11 03:54:49.842+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [30], install = [1]
06-11 03:54:50.622+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 60
06-11 03:54:50.632+0900 I/Tizen::App(  934): (119) > InstallationInProgress [60]
06-11 03:54:50.632+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [60], install = [1]
06-11 03:54:50.632+0900 E/PKGMGR_CERT( 3041): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-11 03:54:50.632+0900 E/PKGMGR_CERT( 3041): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 104
06-11 03:54:50.632+0900 E/PKGMGR_CERT( 3041): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 104
06-11 03:54:50.632+0900 E/PKGMGR_CERT( 3041): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 30 8
06-11 03:54:50.632+0900 E/PKGMGR_CERT( 3041): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 18
06-11 03:54:50.632+0900 E/PKGMGR_CERT( 3041): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 18
06-11 03:54:50.632+0900 E/PKGMGR_CERT( 3041): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 8
06-11 03:54:50.652+0900 E/PKGMGR_CERT( 3041): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
06-11 03:54:50.652+0900 E/rpm-installer( 3041): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.local/shared], errno=[2][No such file or directory]
06-11 03:54:50.652+0900 E/rpm-installer( 3041): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared]
06-11 03:54:50.652+0900 E/rpm-installer( 3041): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.local/shared/data]
06-11 03:54:50.652+0900 E/rpm-installer( 3041): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared/res]
06-11 03:54:50.652+0900 E/rpm-installer( 3041): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.local/tizen-manifest.xml]
06-11 03:54:50.652+0900 E/rpm-installer( 3041): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.local/author-signature.xml]
06-11 03:54:50.652+0900 E/rpm-installer( 3041): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.local/signature1.xml]
06-11 03:54:50.652+0900 E/rpm-installer( 3041): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.local.xml]
06-11 03:54:51.162+0900 E/rpm-installer( 3041): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.local/shared/data]))
06-11 03:54:51.632+0900 E/PKGMGR_SERVER( 3040): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-11 03:54:51.822+0900 E/PKGMGR_INFO( 3041): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-11 03:54:51.822+0900 E/PKGMGR_INSTALLER( 3041): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-11 03:54:51.832+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
06-11 03:54:51.832+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
06-11 03:54:51.832+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-11 03:54:51.842+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 100
06-11 03:54:51.842+0900 I/Tizen::App(  934): (119) > InstallationInProgress [100]
06-11 03:54:51.842+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [100], install = [1]
06-11 03:54:51.842+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: end, val: ok
06-11 03:54:51.842+0900 I/Tizen::App(  934): (78) > Installation is Completed. [Package = org.tizen.local]
06-11 03:54:51.842+0900 I/Tizen::App(  934): (663) > Enter. package(org.tizen.local), installationResult(0)
06-11 03:54:51.852+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.local]
06-11 03:54:51.852+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.local]
06-11 03:54:51.852+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
06-11 03:54:51.852+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
06-11 03:54:51.852+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.local]
06-11 03:54:51.872+0900 I/Tizen::App(  934): (1360) > package(org.tizen.local), version(1.0.0), type(rpm), displayName(local), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.local), storeClient(), appRootPath(/opt/usr/apps/org.tizen.local)
06-11 03:54:51.872+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-11 03:54:51.872+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-11 03:54:51.912+0900 I/Tizen::App(  934): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.local]
06-11 03:54:51.922+0900 I/Tizen::App(  934): (416) > appName = [local]
06-11 03:54:51.922+0900 I/Tizen::App(  934): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-11 03:54:51.922+0900 E/PKGMGR_INFO(  934): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-11 03:54:51.922+0900 I/Tizen::App(  934): (675) > Application count(1) in this package
06-11 03:54:51.922+0900 I/Tizen::App(  934): (855) > Enter.
06-11 03:54:51.922+0900 I/Tizen::App(  934): (695) > Exit.
06-11 03:54:51.922+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [end], Value = [ok], install = [1]
06-11 03:54:51.932+0900 I/Tizen::App(  934): (416) > appName = [local]
06-11 03:54:51.932+0900 I/Tizen::App(  934): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-11 03:54:51.942+0900 I/Tizen::App(  934): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.local.info]
06-11 03:54:51.942+0900 I/Tizen::App(  934): (131) > Enter
06-11 03:54:51.942+0900 I/Tizen::App(  934): (137) > org.tizen.local does not have launch condition
06-11 03:54:51.942+0900 I/Tizen::App(  934): (898) > Exit.
06-11 03:54:53.492+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 0
06-11 03:54:53.502+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-11 03:54:53.512+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-11 03:54:53.512+0900 E/AUL_AMD (  439): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-11 03:54:53.592+0900 I/CAPI_APPFW_APPLICATION( 3108): app_main.c: ui_app_main(699) > app_efl_main
06-11 03:54:53.622+0900 I/UXT     ( 3108): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-11 03:54:53.632+0900 E/PKGMGR_SERVER( 3040): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-11 03:54:53.632+0900 E/PKGMGR_SERVER( 3040): pkgmgr-server.c: main(1704) > package manager server terminated.
06-11 03:54:53.652+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 03:54:53.652+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 03:54:53.652+0900 E/RESOURCED(  773): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 385
06-11 03:54:53.662+0900 I/Tizen::App(  934): (499) > LaunchedApp(org.tizen.local)
06-11 03:54:53.662+0900 I/Tizen::App(  934): (733) > Finished invoking application event listener for org.tizen.local, 3108.
06-11 03:54:53.672+0900 I/Tizen::App(  965): (733) > Finished invoking application event listener for org.tizen.local, 3108.
06-11 03:54:53.712+0900 I/CAPI_APPFW_APPLICATION( 3108): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-11 03:54:53.902+0900 E/EFL     ( 3108): elementary<3108> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb8223b38 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 03:54:53.912+0900 E/EFL     ( 3108): evas_main<3108> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-11 03:54:53.932+0900 E/EFL     ( 3108): evas_main<3108> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-11 03:54:53.942+0900 I/CAPI_APPFW_APPLICATION( 3108): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-11 03:54:53.952+0900 I/APP_CORE( 3108): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-11 03:54:53.952+0900 I/APP_CORE( 3108): appcore-efl.c: __do_app(511) > [APP 3108] Initial Launching, call the resume_cb
06-11 03:54:53.952+0900 I/CAPI_APPFW_APPLICATION( 3108): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-11 03:54:54.002+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3108
06-11 03:54:54.012+0900 W/APP_CORE( 3108): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
06-11 03:54:54.042+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 03:54:54.052+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.local, pid = 3108"
06-11 03:54:54.072+0900 I/Tizen::System(  965): (259) > Active app [org.tizen.], current [org.tizen.] 
06-11 03:54:54.072+0900 I/Tizen::System(  965): (273) > Current App[org.tizen.] is already actived.
06-11 03:54:54.152+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 03:54:54.152+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 03:54:54.152+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-11 03:54:55.192+0900 E/EFL     ( 3108): elementary<3108> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb82b3280 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 03:56:39.992+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 0
06-11 03:56:40.002+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/alarm-server, ret : 0
06-11 03:56:40.012+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/alarm-server, ret : 0
06-11 03:56:40.012+0900 E/AUL_AMD (  439): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-11 03:56:40.082+0900 I/CAPI_APPFW_APPLICATION(23484): app_main.c: app_efl_main(129) > app_efl_main
06-11 03:56:40.082+0900 I/CAPI_APPFW_APPLICATION(23484): app_main.c: app_appcore_create(152) > app_appcore_create
06-11 03:56:40.092+0900 I/EFL-ASSIST(23484): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [b8a554d8]
06-11 03:56:40.092+0900 I/EFL-ASSIST(23484): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b8ae5b08) from (/usr/share/themes/ChangeableColorTable2.xml) is created
06-11 03:56:40.112+0900 I/EFL-ASSIST(23484): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b8ae5b08) is freed
06-11 03:56:40.112+0900 I/EFL-ASSIST(23484): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b8ae5b50) from (/usr/apps/com.samsung.dailybriefing-weather-lite/shared/res/tables/com.samsung.dailybriefing-weather-lite_ChangeableColorInfo.xml) is created
06-11 03:56:40.112+0900 I/EFL-ASSIST(23484): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b8b399a0) from (/usr/apps/com.samsung.dailybriefing-weather-lite/shared/res/tables/com.samsung.dailybriefing-weather-lite_ChangeableColorInfo_font.xml) is created
06-11 03:56:40.132+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 03:56:40.132+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 03:56:40.132+0900 E/RESOURCED(  773): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 380
06-11 03:56:40.142+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __alarm_expired(1223) > alarm_id[2047417706] is expired.
06-11 03:56:40.142+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __alarm_remove_from_list(389) > [alarm-server]:Remove alarm id(2047417706)
06-11 03:56:40.152+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 10-6-2015, 19:13:08 (UTC).
06-11 03:56:40.152+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
06-11 03:56:40.182+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 10-6-2015, 19:13:08 (UTC).
06-11 03:56:40.292+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
06-11 03:56:40.302+0900 W/ALARM_MANAGER(23484): alarm-lib.c: alarmmgr_add_alarm_appsvc(944) > trigger_at_time(21600), start(11-6-2015, 09:56:40), repeat(0), interval(0), type(-2147483648)
06-11 03:56:40.342+0900 W/ALARM_MANAGER(  410): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
06-11 03:56:40.342+0900 W/ALARM_MANAGER(  410): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1433984200, Thu Jun 11 09:56:40 2015
06-11 03:56:40.342+0900 W/ALARM_MANAGER(  410): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 990965751, next duetime: 1433984200
06-11 03:56:40.342+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __alarm_add_to_list(310) > [alarm-server]: After add alarm_id(990965751)
06-11 03:56:40.362+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __alarm_create_appsvc(754) > [alarm-server]:alarm_context.c_due_time(1433963588), due_time(1433984200)
06-11 03:56:40.362+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 10-6-2015, 19:13:08 (UTC).
06-11 03:56:40.452+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
06-11 03:56:40.452+0900 I/CAPI_APPFW_APPLICATION(23484): app_main.c: app_appcore_reset(245) > app_appcore_reset
06-11 03:56:40.452+0900 E/weather-app(23484): weather-main.c: _app_control(457) > [0;40;31mAUTO_REFRESH LAUNCHED BY ALARM[0;m
06-11 03:56:40.462+0900 I/CAPI_NETWORK_CONNECTION(23484): connection.c: connection_create(363) > New handle created[0xb8b7f630]
06-11 03:56:40.462+0900 I/CAPI_NETWORK_CONNECTION(23484): connection.c: connection_get_type(412) > Connected Network = 0
06-11 03:56:40.462+0900 I/CAPI_NETWORK_CONNECTION(23484): connection.c: connection_destroy(379) > Destroy handle: 0xb8b7f630
06-11 03:56:40.482+0900 W/ALARM_MANAGER(  410): alarm-manager.c: alarm_manager_alarm_delete_all(1808) > alarm_id[990965751] is removed.
06-11 03:56:40.482+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 10-6-2015, 19:13:08 (UTC).
06-11 03:56:40.602+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
06-11 03:56:40.612+0900 W/ALARM_MANAGER(23484): alarm-lib.c: __alarmmgr_init_appsvc(583) > alarm was already initialized
06-11 03:56:40.612+0900 W/ALARM_MANAGER(23484): alarm-lib.c: alarmmgr_add_alarm_appsvc(944) > trigger_at_time(21600), start(11-6-2015, 09:56:41), repeat(0), interval(0), type(-2147483648)
06-11 03:56:40.642+0900 I/Tizen::App(  934): (499) > LaunchedApp(com.samsung.dailybriefing-weather-lite)
06-11 03:56:40.642+0900 I/Tizen::App(  934): (733) > Finished invoking application event listener for com.samsung.dailybriefing-weather-lite, 23484.
06-11 03:56:40.642+0900 I/Tizen::App(  965): (733) > Finished invoking application event listener for com.samsung.dailybriefing-weather-lite, 23484.
06-11 03:56:40.662+0900 W/ALARM_MANAGER(  410): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
06-11 03:56:40.662+0900 W/ALARM_MANAGER(  410): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1433984201, Thu Jun 11 09:56:41 2015
06-11 03:56:40.662+0900 W/ALARM_MANAGER(  410): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 990965751, next duetime: 1433984201
06-11 03:56:40.662+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __alarm_add_to_list(310) > [alarm-server]: After add alarm_id(990965751)
06-11 03:56:40.682+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __alarm_create_appsvc(754) > [alarm-server]:alarm_context.c_due_time(1433963588), due_time(1433984201)
06-11 03:56:40.682+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 10-6-2015, 19:13:08 (UTC).
06-11 03:56:40.762+0900 W/ALARM_MANAGER(  410): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
06-11 03:56:40.792+0900 I/APP_CORE(23484): appcore-efl.c: __do_app(509) > Legacy lifecycle: 1
06-11 03:56:41.132+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 03:56:41.132+0900 W/AUL_AMD (  439): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
06-11 03:56:41.692+0900 I/UXT     ( 3550): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-11 03:57:52.462+0900 E/PKGMGR_SERVER( 3878): pkgmgr-server.c: main(1608) > server start
06-11 03:57:52.572+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 03:57:52.572+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 03:57:52.572+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(142) > dead_pid = 3108 pgid = 3108
06-11 03:57:52.572+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(123) > dead_pid(3108)
06-11 03:57:52.572+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-11 03:57:52.572+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-11 03:57:52.592+0900 I/Tizen::System(  965): (246) > Terminated app [org.tizen.local]
06-11 03:57:52.592+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 03:57:52.592+0900 I/Tizen::App(  934): (243) > App[org.tizen.local] pid[3108] terminate event is forwarded
06-11 03:57:52.592+0900 I/Tizen::System(  934): (256) > osp.accessorymanager.service provider is found.
06-11 03:57:52.592+0900 I/Tizen::System(  934): (196) > Accessory Owner is removed [org.tizen.local, 3108, ]
06-11 03:57:52.592+0900 I/Tizen::System(  934): (256) > osp.system.service provider is found.
06-11 03:57:52.592+0900 I/Tizen::App(  934): (506) > TerminatedApp(org.tizen.local)
06-11 03:57:52.592+0900 I/Tizen::App(  934): (512) > Not registered pid(3108)
06-11 03:57:52.592+0900 I/Tizen::App(  934): (782) > Finished invoking application event listener for org.tizen.local, 3108.
06-11 03:57:52.592+0900 I/AUL_AMD (  439): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 3108
06-11 03:57:52.602+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 03:57:52.602+0900 I/Tizen::App(  965): (782) > Finished invoking application event listener for org.tizen.local, 3108.
06-11 03:57:52.622+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 03:57:52.622+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8466
06-11 03:57:52.632+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.testuicontrolsample, pid = 8466"
06-11 03:57:52.662+0900 I/Tizen::System(  965): (259) > Active app [org.tizen.], current [org.tizen.] 
06-11 03:57:52.662+0900 I/Tizen::System(  965): (273) > Current App[org.tizen.] is already actived.
06-11 03:57:52.682+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-11 03:57:54.632+0900 E/PKGMGR_SERVER( 3878): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-11 03:57:54.632+0900 E/PKGMGR_SERVER( 3878): pkgmgr-server.c: main(1704) > package manager server terminated.
06-11 03:57:56.292+0900 E/PKGMGR_SERVER( 3983): pkgmgr-server.c: main(1608) > server start
06-11 03:57:56.352+0900 E/PKGMGR  ( 3983): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.local]
06-11 03:57:56.352+0900 E/PKGMGR_SERVER( 3983): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.local 
06-11 03:57:56.352+0900 E/PKGMGR_SERVER( 3983): [0;m
06-11 03:57:56.522+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: start, val: update
06-11 03:57:56.522+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [start], Value = [update], install = [1]
06-11 03:57:56.522+0900 W/AUL_AMD (  439): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
06-11 03:57:56.522+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 30
06-11 03:57:56.522+0900 I/Tizen::App(  934): (119) > InstallationInProgress [30]
06-11 03:57:56.522+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [30], install = [1]
06-11 03:57:57.202+0900 E/PKGMGR_CERT( 3985): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-11 03:57:57.202+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 60
06-11 03:57:57.202+0900 I/Tizen::App(  934): (119) > InstallationInProgress [60]
06-11 03:57:57.202+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [60], install = [1]
06-11 03:57:57.202+0900 E/PKGMGR_CERT( 3985): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 104
06-11 03:57:57.202+0900 E/PKGMGR_CERT( 3985): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 104
06-11 03:57:57.202+0900 E/PKGMGR_CERT( 3985): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 30 8
06-11 03:57:57.202+0900 E/PKGMGR_CERT( 3985): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 18
06-11 03:57:57.202+0900 E/PKGMGR_CERT( 3985): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 18
06-11 03:57:57.202+0900 E/PKGMGR_CERT( 3985): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 8
06-11 03:57:57.222+0900 E/PKGMGR_CERT( 3985): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
06-11 03:57:57.222+0900 E/rpm-installer( 3985): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.local/shared], errno=[2][No such file or directory]
06-11 03:57:57.232+0900 E/rpm-installer( 3985): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared]
06-11 03:57:57.232+0900 E/rpm-installer( 3985): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.local/shared/data]
06-11 03:57:57.232+0900 E/rpm-installer( 3985): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared/res]
06-11 03:57:57.232+0900 E/rpm-installer( 3985): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.local/tizen-manifest.xml]
06-11 03:57:57.232+0900 E/rpm-installer( 3985): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.local/author-signature.xml]
06-11 03:57:57.232+0900 E/rpm-installer( 3985): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.local/signature1.xml]
06-11 03:57:57.232+0900 E/rpm-installer( 3985): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.local.xml]
06-11 03:57:57.732+0900 E/rpm-installer( 3985): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.local/shared/data]))
06-11 03:57:58.402+0900 E/PKGMGR_INFO( 3985): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-11 03:57:58.402+0900 E/PKGMGR_INSTALLER( 3985): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-11 03:57:58.412+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 100
06-11 03:57:58.412+0900 I/Tizen::App(  934): (119) > InstallationInProgress [100]
06-11 03:57:58.412+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [100], install = [1]
06-11 03:57:58.422+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
06-11 03:57:58.422+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
06-11 03:57:58.422+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-11 03:57:58.442+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: end, val: ok
06-11 03:57:58.442+0900 I/Tizen::App(  934): (78) > Installation is Completed. [Package = org.tizen.local]
06-11 03:57:58.442+0900 I/Tizen::App(  934): (663) > Enter. package(org.tizen.local), installationResult(0)
06-11 03:57:58.442+0900 I/Tizen::App(  934): (1360) > package(org.tizen.local), version(1.0.0), type(rpm), displayName(local), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.local), storeClient(), appRootPath(/opt/usr/apps/org.tizen.local)
06-11 03:57:58.472+0900 I/Tizen::App(  934): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.local]
06-11 03:57:58.482+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.local]
06-11 03:57:58.482+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.local]
06-11 03:57:58.482+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
06-11 03:57:58.482+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
06-11 03:57:58.482+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.local]
06-11 03:57:58.482+0900 I/Tizen::App(  934): (416) > appName = [local]
06-11 03:57:58.482+0900 I/Tizen::App(  934): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-11 03:57:58.482+0900 E/PKGMGR_INFO(  934): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-11 03:57:58.482+0900 I/Tizen::App(  934): (675) > Application count(1) in this package
06-11 03:57:58.482+0900 I/Tizen::App(  934): (855) > Enter.
06-11 03:57:58.492+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-11 03:57:58.492+0900 E/cluster-home(  599): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-11 03:57:58.492+0900 I/Tizen::App(  934): (416) > appName = [local]
06-11 03:57:58.492+0900 I/Tizen::App(  934): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-11 03:57:58.492+0900 I/Tizen::App(  934): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.local.info]
06-11 03:57:58.492+0900 I/Tizen::App(  934): (131) > Enter
06-11 03:57:58.502+0900 I/Tizen::App(  934): (137) > org.tizen.local does not have launch condition
06-11 03:57:58.502+0900 I/Tizen::App(  934): (898) > Exit.
06-11 03:57:58.502+0900 I/Tizen::App(  934): (695) > Exit.
06-11 03:57:58.502+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.local], Key = [end], Value = [ok], install = [96]
06-11 03:57:58.632+0900 E/PKGMGR_SERVER( 3983): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-11 03:57:58.632+0900 E/PKGMGR_SERVER( 3983): pkgmgr-server.c: main(1704) > package manager server terminated.
06-11 03:58:00.142+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 0
06-11 03:58:00.152+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-11 03:58:00.162+0900 I/AUL     (  439): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-11 03:58:00.162+0900 E/AUL_AMD (  439): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-11 03:58:00.242+0900 I/CAPI_APPFW_APPLICATION( 4052): app_main.c: ui_app_main(699) > app_efl_main
06-11 03:58:00.282+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 03:58:00.282+0900 E/RESOURCED(  773): nfacct-rule.c: generate_counter_name(778) > [generate_counter_name,778] Can't get interface name for counter , iftype 0)!
06-11 03:58:00.282+0900 E/RESOURCED(  773): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 382
06-11 03:58:00.282+0900 I/UXT     ( 4052): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-11 03:58:00.292+0900 I/Tizen::App(  965): (733) > Finished invoking application event listener for org.tizen.local, 4052.
06-11 03:58:00.292+0900 I/Tizen::App(  934): (499) > LaunchedApp(org.tizen.local)
06-11 03:58:00.292+0900 I/Tizen::App(  934): (733) > Finished invoking application event listener for org.tizen.local, 4052.
06-11 03:58:00.322+0900 I/CAPI_APPFW_APPLICATION( 4052): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-11 03:58:00.492+0900 E/EFL     ( 4052): elementary<4052> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb8223b38 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 03:58:00.502+0900 E/EFL     ( 4052): evas_main<4052> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-11 03:58:00.512+0900 E/EFL     ( 4052): evas_main<4052> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-11 03:58:00.522+0900 I/CAPI_APPFW_APPLICATION( 4052): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-11 03:58:00.542+0900 I/APP_CORE( 4052): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-11 03:58:00.542+0900 I/APP_CORE( 4052): appcore-efl.c: __do_app(511) > [APP 4052] Initial Launching, call the resume_cb
06-11 03:58:00.542+0900 I/CAPI_APPFW_APPLICATION( 4052): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-11 03:58:00.572+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4052
06-11 03:58:00.582+0900 W/AUL_AMD (  439): amd_request.c: __request_handler(601) > __request_handler: 15
06-11 03:58:00.592+0900 I/indicator(  481): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.local, pid = 4052"
06-11 03:58:00.622+0900 W/APP_CORE( 4052): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
06-11 03:58:00.652+0900 I/Tizen::System(  965): (259) > Active app [org.tizen.], current [org.tizen.] 
06-11 03:58:00.652+0900 I/Tizen::System(  965): (273) > Current App[org.tizen.] is already actived.
06-11 03:58:00.712+0900 I/CAPI_APPFW_APPLICATION( 8466): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-11 03:58:00.722+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 03:58:00.722+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 03:58:01.822+0900 E/EFL     ( 4052): elementary<4052> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb82b33c8 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-11 03:58:01.942+0900 W/AUL_AMD (  439): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-11 03:58:01.942+0900 W/AUL_AMD (  439): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-11 03:58:01.942+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4052 pgid = 4052
06-11 03:58:01.942+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(123) > dead_pid(4052)
06-11 03:58:01.942+0900 I/AUL_PAD (  480): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-11 03:58:01.942+0900 I/AUL_PAD (  480): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-11 03:58:01.962+0900 I/Tizen::System(  965): (246) > Terminated app [org.tizen.local]
06-11 03:58:01.962+0900 I/Tizen::Io(  965): (729) > Entry not found
06-11 03:58:01.962+0900 I/Tizen::App(  934): (243) > App[org.tizen.local] pid[4052] terminate event is forwarded
06-11 03:58:01.962+0900 I/Tizen::System(  934): (256) > osp.accessorymanager.service provider is found.
06-11 03:58:01.962+0900 I/Tizen::System(  934): (196) > Accessory Owner is removed [org.tizen.local, 4052, ]
06-11 03:58:01.962+0900 I/Tizen::System(  934): (256) > osp.system.service provider is found.
06-11 03:58:01.962+0900 I/Tizen::App(  934): (506) > TerminatedApp(org.tizen.local)
06-11 03:58:01.962+0900 I/Tizen::App(  934): (512) > Not registered pid(4052)
06-11 03:58:01.962+0900 I/Tizen::App(  934): (782) > Finished invoking application event listener for org.tizen.local, 4052.
06-11 03:58:01.962+0900 I/AUL_AMD (  439): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 4052
06-11 03:58:01.972+0900 I/Tizen::System(  965): (157) > change brightness system value.
06-11 03:58:01.972+0900 I/Tizen::App(  965): (782) > Finished invoking application event listener for org.tizen.local, 4052.
06-11 03:58:02.002+0900 W/CRASH_MANAGER( 4059): worker.c: worker_job(1236) > 11040526c6f63143396268
