S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: local
PID: 13937
Date: 2015-06-21 17:33:05+0900
Executable File Path: /opt/usr/apps/org.tizen.local/bin/local
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0xbeda9b84, r1   = 0xffffffff
r2   = 0xbeda9b84, r3   = 0x58c01600
r4   = 0x00000003, r5   = 0xb4d95943
r6   = 0xb7c54d68, r7   = 0xbeda9bc0
r8   = 0x00000000, r9   = 0xb7ba6c40
r10  = 0xb376cd70, fp   = 0x00000001
ip   = 0xb4d9e1cc, sp   = 0xbeda99a0
lr   = 0xb4d9439f, pc   = 0xb6c8f9ac
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    117192 KB
Buffers:     44756 KB
Cached:     211188 KB
VmPeak:      79396 KB
VmSize:      79348 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18692 KB
VmRSS:       18692 KB
VmData:      32892 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23768 KB
VmPTE:          54 KB
VmSwap:          0 KB

Maps Information
b3896000 b389b000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/linux-gnueabi-armv7l-1.7.99/module.so
b38a3000 b38b3000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b38b4000 b38b9000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b4550000 b4551000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b4559000 b4560000 r-xp /usr/lib/libfeedback.so.0.1.4
b4576000 b4577000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b457f000 b4581000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b4589000 b458a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b4592000 b45a9000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b4705000 b4709000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b4712000 b471c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4965000 b4a2f000 r-xp /usr/lib/libCOREGL.so.4.0
b4a40000 b4a45000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4a4d000 b4a4f000 r-xp /usr/lib/libiniparser.so.0
b4a59000 b4b98000 r-xp /usr/lib/libicui18n.so.51.1
b4ba8000 b4baa000 r-xp /usr/lib/libdri2.so.0.0.0
b4bb2000 b4bb9000 r-xp /usr/lib/libtbm.so.1.0.0
b4bc1000 b4bc8000 r-xp /usr/lib/libdrm.so.2.4.0
b4bd1000 b4bd9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4be1000 b4be6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4bee000 b4bf3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4bfc000 b4bfd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4c06000 b4c1e000 r-xp /usr/lib/libpng12.so.0.50.0
b4c26000 b4c29000 r-xp /usr/lib/libEGL.so.1.4
b4c31000 b4c3f000 r-xp /usr/lib/libGLESv2.so.2.0
b4c48000 b4c4c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4c55000 b4c5d000 r-xp /usr/lib/libui-extension.so.0.1.0
b4c5e000 b4c61000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4c69000 b4c6c000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4c74000 b4d2a000 r-xp /usr/lib/libcairo.so.2.11200.14
b4d35000 b4d47000 r-xp /usr/lib/libtts.so
b4d4f000 b4d65000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4d6d000 b4d74000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4d7f000 b4d89000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4d92000 b4d96000 r-xp /opt/usr/apps/org.tizen.local/bin/local
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
b7a3f000 b7df2000 rw-p [heap]
bed8a000 bedab000 rwxp [stack]
End of Maps Information

Callstack Information (PID:13937)
Call Stack Count: 2
 0: strcpy + 0x8 (0xb6c8f9ac) [/lib/libc.so.6] + 0x729ac
 1: clicked_submit_btn_cb + 0xde (0xb4d9439f) [/opt/usr/apps/org.tizen.local/bin/local] + 0x239f
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
ction_destroy(379) > Destroy handle: 0xb7dd1728
06-21 17:32:50.651+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Mon[0;m
06-21 17:32:50.681+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
06-21 17:32:50.731+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
06-21 17:32:50.761+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-21 17:32:50.771+0900 I/CAPI_APPFW_APPLICATION(13776): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:50.771+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:50.771+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:50.771+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:32:50.791+0900 W/LOCKSCREEN(  562): dbus.c: _dbus_message_recv_cb(167) > [_dbus_message_recv_cb:167:W] rotation changed:0
06-21 17:32:50.791+0900 W/LOCKSCREEN(  562): camera.c: _angle_changed_cb(193) > [_angle_changed_cb:193:W] angle:0
06-21 17:32:50.791+0900 W/LOCKSCREEN(  562): camera.c: camera_view_action(157) > [camera_view_action:157:W] rotation:0
06-21 17:32:50.821+0900 E/weather-live(10830): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-21 17:32:50.841+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-21 17:32:50.841+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-21 17:32:50.841+0900 E/LOCKSCREEN(  562): progress_circle.c: unlock_mouse_up(276) > 
06-21 17:32:50.841+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:80001:VIEW_GESTURED
06-21 17:32:50.841+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:80001 event_info:0
06-21 17:32:50.841+0900 W/LOCKSCREEN(  562): daemon.c: _lcd_timeout_timer_unset(620) > [_lcd_timeout_timer_unset:620:W] lcd off timer unset
06-21 17:32:50.841+0900 W/LOCKSCREEN(  562): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
06-21 17:32:50.841+0900 W/LOCKSCREEN(  562): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
06-21 17:32:50.841+0900 W/LOCKSCREEN(  562): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
06-21 17:32:50.841+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event_delay(915) > [lockd_event_delay:915:W] dealyed event:2:UNLOCK wait for:0.500000
06-21 17:32:50.871+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_create(363) > New handle created[0xb7c6a0a0]
06-21 17:32:50.871+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_get_type(412) > Connected Network = 0
06-21 17:32:50.871+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_destroy(379) > Destroy handle: 0xb7c6a0a0
06-21 17:32:50.891+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Mon[0;m
06-21 17:32:50.931+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
06-21 17:32:50.961+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
06-21 17:32:51.001+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-21 17:32:51.041+0900 E/weather-live(10830): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-21 17:32:51.071+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-21 17:32:51.071+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-21 17:32:51.121+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_create(363) > New handle created[0xb7cec768]
06-21 17:32:51.121+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_get_type(412) > Connected Network = 0
06-21 17:32:51.121+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_destroy(379) > Destroy handle: 0xb7cec768
06-21 17:32:51.141+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Mon[0;m
06-21 17:32:51.211+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
06-21 17:32:51.271+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
06-21 17:32:51.331+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-21 17:32:51.341+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:2 event_info:0
06-21 17:32:51.341+0900 W/LOCKSCREEN(  562): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
06-21 17:32:51.341+0900 W/LOCKSCREEN(  562): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
06-21 17:32:51.341+0900 E/WALLPAPER_SERVICE_COMMON(  562): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
06-21 17:32:51.351+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=13776
06-21 17:32:51.361+0900 I/CAPI_APPFW_APPLICATION(13776): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-21 17:32:51.401+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 17:32:51.401+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 17:32:51.411+0900 W/LOCKSCREEN(  562): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1E00008] is now visible(1)
06-21 17:32:51.411+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:10002:WIN_BECOME_INVISIBLE
06-21 17:32:51.411+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:10002 event_info:0
06-21 17:32:51.411+0900 I/CAPI_APPFW_APPLICATION(  562): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-21 17:32:51.411+0900 E/LOCKSCREEN(  562): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
06-21 17:32:51.411+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:20002:APP_PAUSE
06-21 17:32:51.411+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:20002 event_info:0
06-21 17:32:51.411+0900 I/Tizen::System(  993): (259) > Active app [org.tizen.], current [com.samsun] 
06-21 17:32:51.411+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 17:32:51.431+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 17:32:51.451+0900 E/weather-common(10830): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
06-21 17:32:51.451+0900 E/weather-common(10830): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
06-21 17:32:51.531+0900 E/cluster-home(  621): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-21 17:32:51.541+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:51.551+0900 W/LOCKSCREEN(  562): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
06-21 17:32:51.551+0900 E/LOCKSCREEN(  562): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
06-21 17:32:51.551+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:80000:VIEW_IDLE
06-21 17:32:51.551+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:80000 event_info:0
06-21 17:32:51.561+0900 E/LOCKSCREEN(  562): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
06-21 17:32:51.681+0900 E/EFL     (13776): elementary<13776> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7c0a260 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 17:32:51.991+0900 W/LOCKSCREEN(  562): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
06-21 17:32:52.151+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-21 17:32:53.611+0900 E/EFL     (13776): elementary<13776> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b8bba8 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 17:32:54.721+0900 D/local   (13776): hi
06-21 17:32:54.721+0900 D/local   (13776): 1
06-21 17:32:54.851+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 17:32:54.851+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 17:32:54.871+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(142) > dead_pid = 13776 pgid = 13776
06-21 17:32:54.871+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(123) > dead_pid(13776)
06-21 17:32:54.871+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-21 17:32:54.871+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-21 17:32:54.891+0900 I/Tizen::System(  993): (246) > Terminated app [org.tizen.local]
06-21 17:32:54.891+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 17:32:54.901+0900 I/Tizen::App(  978): (243) > App[org.tizen.local] pid[13776] terminate event is forwarded
06-21 17:32:54.901+0900 I/Tizen::System(  978): (256) > osp.accessorymanager.service provider is found.
06-21 17:32:54.901+0900 I/Tizen::System(  978): (196) > Accessory Owner is removed [org.tizen.local, 13776, ]
06-21 17:32:54.901+0900 I/Tizen::System(  978): (256) > osp.system.service provider is found.
06-21 17:32:54.901+0900 I/Tizen::App(  978): (506) > TerminatedApp(org.tizen.local)
06-21 17:32:54.901+0900 I/Tizen::App(  978): (512) > Not registered pid(13776)
06-21 17:32:54.901+0900 I/Tizen::App(  978): (782) > Finished invoking application event listener for org.tizen.local, 13776.
06-21 17:32:54.901+0900 I/AUL_AMD (  447): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 13776
06-21 17:32:54.911+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 17:32:54.911+0900 I/Tizen::App(  993): (782) > Finished invoking application event listener for org.tizen.local, 13776.
06-21 17:32:54.961+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-21 17:32:54.971+0900 W/CRASH_MANAGER(13893): worker.c: worker_job(1198) > 11137766c6f631434875574
06-21 17:32:54.991+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-21 17:32:54.991+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-21 17:32:55.051+0900 I/Tizen::System(  993): (259) > Active app [com.samsun], current [org.tizen.] 
06-21 17:32:55.051+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 17:32:55.061+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 17:32:57.361+0900 I/MALI    (  621): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb20362b8] swap changed from async to sync
06-21 17:32:58.341+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-21 17:32:59.021+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:59.021+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:59.021+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:59.021+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:32:59.141+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:59.141+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:59.141+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:32:59.141+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:32:59.251+0900 W/AUL_AMD (  447): amd_request.c: __request_handler(601) > __request_handler: 1
06-21 17:32:59.331+0900 I/CAPI_APPFW_APPLICATION(13937): app_main.c: ui_app_main(699) > app_efl_main
06-21 17:32:59.361+0900 I/UXT     (13937): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-21 17:32:59.381+0900 E/RESOURCED(  758): nfacct-rule.c: generate_counter_name(733) > [generate_counter_name,733] Can't get interface name for counter , iftype 0)!
06-21 17:32:59.381+0900 E/RESOURCED(  758): nfacct-rule.c: generate_counter_name(733) > [generate_counter_name,733] Can't get interface name for counter , iftype 0)!
06-21 17:32:59.381+0900 E/RESOURCED(  758): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 392
06-21 17:32:59.401+0900 I/Tizen::App(  993): (733) > Finished invoking application event listener for org.tizen.local, 13937.
06-21 17:32:59.401+0900 I/Tizen::App(  978): (499) > LaunchedApp(org.tizen.local)
06-21 17:32:59.401+0900 I/Tizen::App(  978): (733) > Finished invoking application event listener for org.tizen.local, 13937.
06-21 17:32:59.421+0900 I/CAPI_APPFW_APPLICATION(13937): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-21 17:32:59.461+0900 D/local   (13937): -0: 
06-21 17:32:59.461+0900 D/local   (13937): COMMENT = a | 
06-21 17:32:59.461+0900 D/local   (13937): LOCATION_X = b | 
06-21 17:32:59.461+0900 D/local   (13937): LOCATION_Y = c | 
06-21 17:32:59.461+0900 D/local   (13937): TIME_START = d | 
06-21 17:32:59.461+0900 D/local   (13937): TIME_FINISH = 2015-05-12 | 
06-21 17:32:59.461+0900 D/local   (13937): TAG = f | 
06-21 17:32:59.461+0900 D/local   (13937): TITLE = g | 
06-21 17:32:59.461+0900 D/local   (13937): KEY = 1 | 
06-21 17:32:59.461+0900 D/local   (13937): 
06-21 17:32:59.611+0900 E/EFL     (13937): elementary<13937> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b89300 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 17:32:59.621+0900 E/EFL     (13937): evas_main<13937> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-21 17:32:59.631+0900 E/EFL     (13937): evas_main<13937> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-21 17:32:59.651+0900 I/CAPI_APPFW_APPLICATION(13937): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-21 17:32:59.661+0900 I/APP_CORE(13937): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-21 17:32:59.661+0900 I/APP_CORE(13937): appcore-efl.c: __do_app(511) > [APP 13937] Initial Launching, call the resume_cb
06-21 17:32:59.661+0900 I/CAPI_APPFW_APPLICATION(13937): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-21 17:32:59.691+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=13937
06-21 17:32:59.701+0900 W/APP_CORE(13937): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4a00002
06-21 17:32:59.751+0900 I/MALI    (  621): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb20362b8] swap changed from sync to async
06-21 17:32:59.771+0900 I/Tizen::System(  993): (259) > Active app [org.tizen.], current [com.samsun] 
06-21 17:32:59.771+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 17:32:59.811+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 17:32:59.841+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-21 17:32:59.841+0900 E/cluster-home(  621): homescreen-main.cpp: app_pause(355) >  app pause
06-21 17:33:00.851+0900 E/EFL     (13937): elementary<13937> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7c15430 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 17:33:02.081+0900 E/EFL     (13937): elementary<13937> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b8b6c0 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 17:33:02.941+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:33:02.951+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x4a00002 FAILED!
06-21 17:33:02.961+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x4a00002 FAILED!
06-21 17:33:02.961+0900 I/ISE_MULTI(  504): isemain.cpp: slot_set_caps_mode(806) > [0;36m[hidden state:true] mode=1[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff02 value =0x1[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff03 value =0x1[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff04 value =0x1[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff05 value =0x1[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff06 value =0x0[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff07 value =0x1[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff08 value =0x1[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff09 value =0x0[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff0a value =0x1[0m
06-21 17:33:02.971+0900 I/IME_LITE(  479): selectpage.cpp: ResetSelection(28) > [0;36m[0m
06-21 17:33:02.991+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:33:02.991+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:33:02.991+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/use_on) step(-21) failed(2 / No such file or directory)
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/use_on : read buf error(-21). break
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/ise/swiftkey/dlm/use_on error
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: vconf_get_int(2379) > vconf_get_int(504) : db/ise/swiftkey/dlm/onpause_noti error
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:33:03.051+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:33:03.061+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
06-21 17:33:03.061+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
06-21 17:33:03.061+0900 E/VCONF   (  504): vconf.c: vconf_get_int(2379) > vconf_get_int(504) : db/ise/swiftkey/dlm/onpause_noti error
06-21 17:33:03.061+0900 I/ISE_MULTI(  504): isemain.cpp: slot_update_cursor_position(868) > [0;36m[hidden state:false] pos=0[0m
06-21 17:33:03.081+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:33:03.091+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:false][0m
06-21 17:33:03.101+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xe0 value =0x0[0m
06-21 17:33:03.101+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0xe0[0m
06-21 17:33:03.111+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-21 17:33:03.111+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-21 17:33:03.111+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x200 value =0x0[0m
06-21 17:33:03.111+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x200[0m
06-21 17:33:03.111+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:33:03.111+0900 W/IME_LITE(  479): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
06-21 17:33:03.111+0900 W/IME_LITE(  479): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff02 value =0x1[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff03 value =0x1[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff04 value =0x1[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff05 value =0x1[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff06 value =0x0[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff07 value =0x1[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff08 value =0x1[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff09 value =0x0[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff0a value =0x1[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): selectpage.cpp: ResetSelection(28) > [0;36m[0m
06-21 17:33:03.121+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=504
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-21 17:33:03.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-21 17:33:03.271+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 17:33:03.271+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 17:33:03.301+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x1400002 FAILED!
06-21 17:33:03.301+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x1400002 FAILED!
06-21 17:33:04.041+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:33:04.041+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:33:04.051+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:33:04.051+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 1[0m
06-21 17:33:04.051+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.081+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.091+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.091+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.091+0900 I/ISE_MULTI(  504): isemain.cpp: slot_set_caps_mode(806) > [0;36m[hidden state:false] mode=0[0m
06-21 17:33:04.111+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-21 17:33:04.121+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-21 17:33:04.141+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:33:04.141+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:33:04.141+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.201+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.211+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.231+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:33:04.231+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:33:04.241+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.261+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.281+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.301+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:33:04.301+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:33:04.311+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.321+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.331+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.391+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:33:04.391+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:33:04.391+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.411+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.421+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.481+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:33:04.481+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:33:04.491+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:33:04.511+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.531+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:33:04.551+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-21 17:33:05.031+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:33:05.041+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:33:05.041+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:33:05.041+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:false][0m
06-21 17:33:05.051+0900 D/local   (13937): hi
06-21 17:33:05.051+0900 D/local   (13937): 1
06-21 17:33:05.131+0900 W/CRASH_MANAGER(13893): worker.c: worker_job(1198) > 11139376c6f63143487558
