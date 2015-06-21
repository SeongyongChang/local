S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: local
PID: 12901
Date: 2015-06-21 17:30:40+0900
Executable File Path: /opt/usr/apps/org.tizen.local/bin/local
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0xbeda9b84, r1   = 0xffffffff
r2   = 0xbeda9b84, r3   = 0x58c01600
r4   = 0x00000003, r5   = 0xb4d9693b
r6   = 0xb7c12220, r7   = 0xbeda9bc0
r8   = 0x00000000, r9   = 0xb7bafe48
r10  = 0xb3704f40, fp   = 0x00000001
ip   = 0xb4d9eb70, sp   = 0xbeda99a0
lr   = 0xb4d95399, pc   = 0xb6c8f9ac
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    119176 KB
Buffers:     44708 KB
Cached:     210424 KB
VmPeak:      79196 KB
VmSize:      79192 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18556 KB
VmRSS:       18556 KB
VmData:      32740 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23768 KB
VmPTE:          54 KB
VmSwap:          0 KB

Maps Information
b3897000 b389c000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/linux-gnueabi-armv7l-1.7.99/module.so
b38a4000 b38b4000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b38b5000 b38ba000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
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
b7a3f000 b7dcc000 rw-p [heap]
bed8a000 bedab000 rwxp [stack]
End of Maps Information

Callstack Information (PID:12901)
Call Stack Count: 2
 0: strcpy + 0x8 (0xb6c8f9ac) [/lib/libc.so.6] + 0x729ac
 1: clicked_submit_btn_cb + 0xd8 (0xb4d95399) [/opt/usr/apps/org.tizen.local/bin/local] + 0x2399
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
5 28 25"
06-21 17:30:29.541+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-21 17:30:29.541+0900 I/indicator(  473): indicator_box_util.c: _update_display(585) > "Noti Icon : 13 707 5 28 25"
06-21 17:30:30.131+0900 W/CAM_APP (17352): cam_app.c: __cam_app_display_state_changed_cb(7902) > [33mapp state is PRELAUNCH. ignore this[0m
06-21 17:30:30.141+0900 I/Tizen::System(  993): (280) > The screen has been turned on.
06-21 17:30:30.141+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 17:30:30.141+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_create(363) > New handle created[0xb7d81138]
06-21 17:30:30.151+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_get_type(412) > Connected Network = 0
06-21 17:30:30.151+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_destroy(379) > Destroy handle: 0xb7d81138
06-21 17:30:30.151+0900 E/weather-live(10830): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
06-21 17:30:30.151+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_create(363) > New handle created[0xb7b7dce0]
06-21 17:30:30.151+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_get_type(412) > Connected Network = 0
06-21 17:30:30.151+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_destroy(379) > Destroy handle: 0xb7b7dce0
06-21 17:30:30.151+0900 E/weather-live(10830): main.c: dynamicbox_update_content(2015) > [0;40;31mFAIL: network request()[0;m
06-21 17:30:30.161+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 17:30:30.291+0900 E/weather-live(10830): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-21 17:30:30.301+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-21 17:30:30.301+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-21 17:30:30.331+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_create(363) > New handle created[0xb7b56d78]
06-21 17:30:30.331+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_get_type(412) > Connected Network = 0
06-21 17:30:30.331+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_destroy(379) > Destroy handle: 0xb7b56d78
06-21 17:30:30.341+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Mon[0;m
06-21 17:30:30.371+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
06-21 17:30:30.401+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
06-21 17:30:30.421+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-21 17:30:30.461+0900 E/weather-live(10830): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-21 17:30:30.471+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-21 17:30:30.471+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-21 17:30:30.481+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:30.481+0900 W/LOCKSCREEN(  562): dbus.c: _dbus_message_recv_cb(167) > [_dbus_message_recv_cb:167:W] rotation changed:0
06-21 17:30:30.481+0900 W/LOCKSCREEN(  562): camera.c: _angle_changed_cb(193) > [_angle_changed_cb:193:W] angle:0
06-21 17:30:30.481+0900 W/LOCKSCREEN(  562): camera.c: camera_view_action(157) > [camera_view_action:157:W] rotation:0
06-21 17:30:30.481+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:30.481+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:30.481+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:30:30.511+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_create(363) > New handle created[0xb7ce4418]
06-21 17:30:30.511+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_get_type(412) > Connected Network = 0
06-21 17:30:30.511+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_destroy(379) > Destroy handle: 0xb7ce4418
06-21 17:30:30.531+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Mon[0;m
06-21 17:30:30.571+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
06-21 17:30:30.601+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
06-21 17:30:30.631+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-21 17:30:30.681+0900 E/weather-live(10830): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-21 17:30:30.711+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-21 17:30:30.711+0900 E/weather-live(10830): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-21 17:30:30.761+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_create(363) > New handle created[0xb7cd9a88]
06-21 17:30:30.761+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_get_type(412) > Connected Network = 0
06-21 17:30:30.761+0900 I/CAPI_NETWORK_CONNECTION(10830): connection.c: connection_destroy(379) > Destroy handle: 0xb7cd9a88
06-21 17:30:30.781+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Mon[0;m
06-21 17:30:30.831+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
06-21 17:30:30.871+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
06-21 17:30:30.911+0900 E/weather-common(10830): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-21 17:30:30.951+0900 E/weather-common(10830): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
06-21 17:30:30.951+0900 E/weather-common(10830): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
06-21 17:30:31.031+0900 E/cluster-home(  621): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-21 17:30:31.041+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:31.091+0900 E/LOCKSCREEN(  562): progress_circle.c: unlock_mouse_up(276) > 
06-21 17:30:31.091+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:80001:VIEW_GESTURED
06-21 17:30:31.091+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:80001 event_info:0
06-21 17:30:31.091+0900 W/LOCKSCREEN(  562): daemon.c: _lcd_timeout_timer_unset(620) > [_lcd_timeout_timer_unset:620:W] lcd off timer unset
06-21 17:30:31.091+0900 W/LOCKSCREEN(  562): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
06-21 17:30:31.091+0900 W/LOCKSCREEN(  562): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
06-21 17:30:31.101+0900 W/LOCKSCREEN(  562): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
06-21 17:30:31.101+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event_delay(915) > [lockd_event_delay:915:W] dealyed event:2:UNLOCK wait for:0.500000
06-21 17:30:31.381+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-21 17:30:31.601+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:2 event_info:0
06-21 17:30:31.601+0900 W/LOCKSCREEN(  562): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
06-21 17:30:31.601+0900 W/LOCKSCREEN(  562): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
06-21 17:30:31.601+0900 E/WALLPAPER_SERVICE_COMMON(  562): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
06-21 17:30:31.611+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12901
06-21 17:30:31.621+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-21 17:30:31.631+0900 W/LOCKSCREEN(  562): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1E00008] is now visible(1)
06-21 17:30:31.631+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:10002:WIN_BECOME_INVISIBLE
06-21 17:30:31.631+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:10002 event_info:0
06-21 17:30:31.641+0900 I/CAPI_APPFW_APPLICATION(  562): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-21 17:30:31.641+0900 E/LOCKSCREEN(  562): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
06-21 17:30:31.641+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:20002:APP_PAUSE
06-21 17:30:31.641+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:20002 event_info:0
06-21 17:30:31.671+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 17:30:31.671+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 17:30:31.671+0900 I/Tizen::System(  993): (259) > Active app [org.tizen.], current [com.samsun] 
06-21 17:30:31.671+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 17:30:31.681+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 17:30:31.811+0900 W/LOCKSCREEN(  562): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
06-21 17:30:31.811+0900 E/LOCKSCREEN(  562): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
06-21 17:30:31.811+0900 W/LOCKSCREEN(  562): daemon.c: lockd_event(902) > [lockd_event:902:W] event:80000:VIEW_IDLE
06-21 17:30:31.811+0900 W/LOCKSCREEN(  562): daemon.c: _event_route(721) > [_event_route:721:W] event:80000 event_info:0
06-21 17:30:31.821+0900 E/LOCKSCREEN(  562): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
06-21 17:30:31.951+0900 E/EFL     (12901): elementary<12901> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7bebd48 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 17:30:32.261+0900 W/LOCKSCREEN(  562): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
06-21 17:30:33.211+0900 E/EFL     (12901): elementary<12901> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b8bbe0 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-21 17:30:33.841+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:33.841+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:33.841+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:33.841+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:30:33.841+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.681+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.681+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.681+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.681+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:30:34.691+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.861+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.861+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.861+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.861+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.861+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:30:34.921+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.921+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.921+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.921+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.921+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:30:34.981+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.981+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.981+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:34.981+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:30:34.991+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.041+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.041+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:30:35.041+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.041+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.041+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.161+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.161+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.161+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.161+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.161+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:30:35.281+0900 I/CAPI_APPFW_APPLICATION(12901): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.281+0900 I/CAPI_APPFW_APPLICATION(10830): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.281+0900 I/CAPI_APPFW_APPLICATION(17352): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.281+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-21 17:30:35.281+0900 W/CAM_APP (17352): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-21 17:30:37.551+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:30:37.571+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x4a00002 FAILED!
06-21 17:30:37.571+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x4a00002 FAILED!
06-21 17:30:37.571+0900 I/ISE_MULTI(  504): isemain.cpp: slot_set_caps_mode(806) > [0;36m[hidden state:true] mode=1[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff02 value =0x1[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff03 value =0x1[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff04 value =0x1[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff05 value =0x1[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff06 value =0x0[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff07 value =0x1[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff08 value =0x1[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff09 value =0x0[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff0a value =0x1[0m
06-21 17:30:37.581+0900 I/IME_LITE(  479): selectpage.cpp: ResetSelection(28) > [0;36m[0m
06-21 17:30:37.601+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:30:37.601+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:30:37.601+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:30:37.611+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:30:37.651+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/use_on) step(-21) failed(2 / No such file or directory)
06-21 17:30:37.651+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/use_on : read buf error(-21). break
06-21 17:30:37.651+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/ise/swiftkey/dlm/use_on error
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: vconf_get_int(2379) > vconf_get_int(504) : db/ise/swiftkey/dlm/onpause_noti error
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
06-21 17:30:37.661+0900 E/VCONF   (  504): vconf.c: vconf_get_int(2379) > vconf_get_int(504) : db/ise/swiftkey/dlm/onpause_noti error
06-21 17:30:37.671+0900 I/ISE_MULTI(  504): isemain.cpp: slot_update_cursor_position(868) > [0;36m[hidden state:false] pos=0[0m
06-21 17:30:37.681+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:false][0m
06-21 17:30:37.691+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xe0 value =0x0[0m
06-21 17:30:37.691+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0xe0[0m
06-21 17:30:37.701+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-21 17:30:37.701+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-21 17:30:37.701+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x200 value =0x0[0m
06-21 17:30:37.701+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x200[0m
06-21 17:30:37.701+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:30:37.701+0900 W/IME_LITE(  479): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
06-21 17:30:37.711+0900 W/IME_LITE(  479): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff02 value =0x1[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff03 value =0x1[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff04 value =0x1[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff05 value =0x1[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff06 value =0x0[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff07 value =0x1[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff08 value =0x1[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff09 value =0x0[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff0a value =0x1[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): selectpage.cpp: ResetSelection(28) > [0;36m[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-21 17:30:37.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-21 17:30:37.751+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=504
06-21 17:30:37.771+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-21 17:30:37.871+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 17:30:37.871+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 17:30:37.911+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x1400002 FAILED!
06-21 17:30:37.911+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x1400002 FAILED!
06-21 17:30:38.391+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:30:38.391+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:30:38.391+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:30:38.391+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 1[0m
06-21 17:30:38.421+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.441+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.451+0900 I/ISE_MULTI(  504): isemain.cpp: slot_set_caps_mode(806) > [0;36m[hidden state:false] mode=0[0m
06-21 17:30:38.451+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.451+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.471+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-21 17:30:38.471+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-21 17:30:38.491+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:30:38.491+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:30:38.491+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.541+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.561+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.561+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:30:38.561+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:30:38.561+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.591+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.601+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.691+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:30:38.691+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:30:38.701+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.721+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.741+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.741+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-21 17:30:38.741+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-21 17:30:38.741+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-21 17:30:38.761+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:38.771+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-21 17:30:40.351+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:30:40.351+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:30:40.361+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-21 17:30:40.361+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:false][0m
06-21 17:30:40.361+0900 D/local   (12901): hi
06-21 17:30:40.371+0900 D/local   (12901): 1
06-21 17:30:40.541+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(142) > dead_pid = 12901 pgid = 12901
06-21 17:30:40.541+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(123) > dead_pid(12901)
06-21 17:30:40.541+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-21 17:30:40.541+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-21 17:30:40.581+0900 I/Tizen::System(  993): (246) > Terminated app [org.tizen.local]
06-21 17:30:40.581+0900 I/Tizen::Io(  993): (729) > Entry not found
06-21 17:30:40.581+0900 I/Tizen::App(  978): (243) > App[org.tizen.local] pid[12901] terminate event is forwarded
06-21 17:30:40.581+0900 I/Tizen::System(  978): (256) > osp.accessorymanager.service provider is found.
06-21 17:30:40.581+0900 I/Tizen::System(  978): (196) > Accessory Owner is removed [org.tizen.local, 12901, ]
06-21 17:30:40.581+0900 I/Tizen::System(  978): (256) > osp.system.service provider is found.
06-21 17:30:40.581+0900 I/Tizen::App(  978): (506) > TerminatedApp(org.tizen.local)
06-21 17:30:40.581+0900 I/Tizen::App(  978): (512) > Not registered pid(12901)
06-21 17:30:40.581+0900 I/Tizen::App(  978): (782) > Finished invoking application event listener for org.tizen.local, 12901.
06-21 17:30:40.581+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-21 17:30:40.581+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-21 17:30:40.591+0900 I/AUL_AMD (  447): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 12901
06-21 17:30:40.591+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x4a00002 FAILED!
06-21 17:30:40.601+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-21 17:30:40.631+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-21 17:30:40.631+0900 I/Tizen::App(  993): (782) > Finished invoking application event listener for org.tizen.local, 12901.
06-21 17:30:40.641+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-21 17:30:40.641+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-21 17:30:40.691+0900 W/CRASH_MANAGER(13124): worker.c: worker_job(1198) > 11129016c6f63143487544
