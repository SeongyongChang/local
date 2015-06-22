S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: local
PID: 29244
Date: 2015-06-22 06:01:12+0900
Executable File Path: /opt/usr/apps/org.tizen.local/bin/local
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x35333034

Register Information
r0   = 0x00000140, r1   = 0x00000000
r2   = 0x58c01600, r3   = 0x58c01600
r4   = 0xb7c72940, r5   = 0xb7c19708
r6   = 0xb7c50f10, r7   = 0x31383830
r8   = 0x00000000, r9   = 0xb7bb3dd0
r10  = 0xb7cea4c8, fp   = 0x00000001
ip   = 0xb6f2ca58, sp   = 0xbeda9bc8
lr   = 0xb4d950f1, pc   = 0x35333034
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     77128 KB
Buffers:     51616 KB
Cached:     236248 KB
VmPeak:     110884 KB
VmSize:     110880 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24548 KB
VmRSS:       24548 KB
VmData:      52176 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       30036 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 29244 TID = 29244
29244 29262 29265 

Maps Information
b0ce1000 b1145000 r-xp /usr/lib/libMOS.so.1.0.65
b1601000 b1e00000 rwxp [stack:29262]
b1e01000 b2600000 rwxp [stack:29265]
b372d000 b3732000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/linux-gnueabi-armv7l-1.7.99/module.so
b373a000 b374a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b374b000 b3750000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b40fc000 b4112000 r-xp /usr/lib/libefreet.so.1.7.99
b4214000 b4216000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b421e000 b4222000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b422b000 b4237000 r-xp /usr/lib/libcapi-network-connection.so.1.0.35
b423f000 b4241000 r-xp /usr/lib/libnlp.so.0.0.0
b4249000 b4252000 r-xp /usr/lib/libconsLauncher.so.1.0.0
b425b000 b4261000 r-xp /usr/lib/libplaceshelper.so.1.0.0
b426a000 b4272000 r-xp /usr/lib/libngeohelper.so.1.0.0
b427a000 b42ef000 r-xp /usr/lib/libPLACESAPI.so.1.0.65
b430f000 b4325000 r-xp /usr/lib/elementary/modules/nlp/linux-gnu-i686-1.7.99/module.so
b4343000 b434a000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.55
b4352000 b4354000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b435c000 b435f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b4372000 b4374000 r-xp /usr/lib/location/module/libwps.so.0.0.0
b437c000 b437f000 r-xp /usr/lib/location/module/libgps.so.0.0.0
b43e7000 b43e8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b43f0000 b43f7000 r-xp /usr/lib/libfeedback.so.0.1.4
b440d000 b440e000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b4416000 b4418000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b4420000 b4421000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b4429000 b4440000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b459c000 b45a0000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b45a9000 b45b3000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b47fc000 b48c6000 r-xp /usr/lib/libCOREGL.so.4.0
b48d7000 b48eb000 r-xp /usr/lib/libnetwork.so.0.0.0
b48f3000 b48fc000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.26
b4904000 b4906000 r-xp /usr/lib/libdevice_info.so.0.0.2
b490e000 b4910000 r-xp /usr/lib/libcryptsvc.so.0.0.2
b4918000 b491d000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4925000 b4940000 r-xp /usr/lib/libdrm-service-core-tizen.so.0.3.9
b4958000 b495f000 r-xp /usr/lib/libminizip.so.1.0.0
b4967000 b4969000 r-xp /usr/lib/libiniparser.so.0
b4973000 b4975000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b497d000 b4984000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b498d000 b4acc000 r-xp /usr/lib/libicui18n.so.51.1
b4adc000 b4ade000 r-xp /usr/lib/libdri2.so.0.0.0
b4ae6000 b4aed000 r-xp /usr/lib/libtbm.so.1.0.0
b4af5000 b4afc000 r-xp /usr/lib/libdrm.so.2.4.0
b4b05000 b4b0d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4b15000 b4b1a000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4b22000 b4b27000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4b30000 b4b31000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4b3a000 b4b52000 r-xp /usr/lib/libpng12.so.0.50.0
b4b5a000 b4b5d000 r-xp /usr/lib/libEGL.so.1.4
b4b65000 b4b73000 r-xp /usr/lib/libGLESv2.so.2.0
b4b7c000 b4b85000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4b8d000 b4b91000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4b9a000 b4bb6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4bbf000 b4bc7000 r-xp /usr/lib/libui-extension.so.0.1.0
b4bc8000 b4bcb000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4bd3000 b4bd6000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4bde000 b4c94000 r-xp /usr/lib/libcairo.so.2.11200.14
b4c9f000 b4cb1000 r-xp /usr/lib/libtts.so
b4cb9000 b4ccc000 r-xp /usr/lib/libmdm.so.1.0.88
b4cd4000 b4cef000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4cf7000 b4cfd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b4d05000 b4d1b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4d23000 b4d50000 r-xp /usr/lib/libSLP-location.so.0.0.0
b4d59000 b4d60000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4d69000 b4d74000 r-xp /usr/lib/libcapi-location-manager.so.0.3.3
b4d7f000 b4d89000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4d92000 b4d97000 r-xp /opt/usr/apps/org.tizen.local/bin/local
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
b7a3f000 b7e53000 rw-p [heap]
bed8a000 bedab000 rwxp [stack]
b7a3f000 b7e53000 rw-p [heap]
bed8a000 bedab000 rwxp [stack]
End of Maps Information

Callstack Information (PID:29244)
Call Stack Count: 1
 0: (0x35333034) (null)
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
) > __app_dead_handler, pid: 27162
06-22 06:00:48.684+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-22 06:00:48.694+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 06:00:48.694+0900 I/Tizen::App(  993): (782) > Finished invoking application event listener for org.tizen.local, 27162.
06-22 06:00:48.694+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 06:00:48.694+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 06:00:48.704+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-22 06:00:48.704+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-22 06:00:48.734+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_create(363) > New handle created[0xb7cd36e0]
06-22 06:00:48.734+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_get_type(412) > Connected Network = 2
06-22 06:00:48.734+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_destroy(379) > Destroy handle: 0xb7cd36e0
06-22 06:00:48.744+0900 E/weather-live(26999): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
06-22 06:00:48.744+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_create(363) > New handle created[0xb7ccc080]
06-22 06:00:48.744+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_get_type(412) > Connected Network = 2
06-22 06:00:48.744+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_destroy(379) > Destroy handle: 0xb7ccc080
06-22 06:00:48.744+0900 I/Tizen::System(  993): (259) > Active app [com.samsun], current [org.tizen.] 
06-22 06:00:48.744+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 06:00:48.754+0900 E/weather-live(26999): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 06:00:48.784+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:48.784+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:48.784+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:48.794+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 06:00:48.804+0900 E/weather-live(26999): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 06:00:48.834+0900 E/weather-live(26999): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 06:00:48.844+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:48.844+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:48.844+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:48.874+0900 E/weather-common(26999): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
06-22 06:00:48.874+0900 E/weather-common(26999): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
06-22 06:00:48.884+0900 E/cluster-home(  621): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-22 06:00:48.894+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:48.894+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:49.674+0900 E/libgps_d(19743): [proxy__gps_stop][line = 1057]: stop failed error(-1)
06-22 06:00:49.674+0900 E/CAPI_LOCATION_MANAGER(  929): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
06-22 06:00:49.684+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:49.684+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:49.684+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:49.684+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:49.824+0900 E/CAPI_LOCATION_MANAGER(  929): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
06-22 06:00:49.864+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:49.864+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:49.864+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:49.864+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:50.044+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.044+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.044+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.044+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:50.224+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.224+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.224+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.224+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:50.404+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.404+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.404+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.404+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:50.584+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.584+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.584+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.584+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:50.704+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.704+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.704+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.704+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:50.944+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.944+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.944+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:50.944+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:51.064+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.064+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.064+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.064+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:51.084+0900 I/MALI    (  621): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb20362b8] swap changed from async to sync
06-22 06:00:51.244+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.244+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.244+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.244+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:51.304+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.304+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.304+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:51.304+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.604+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.604+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.604+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:51.604+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.664+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.664+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.664+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:51.664+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.844+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.844+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.844+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.854+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:51.964+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.964+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.964+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:51.964+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:52.094+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:52.094+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:52.094+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:52.094+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:52.104+0900 E/PKGMGR  (29179): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.local]
06-22 06:00:52.104+0900 E/PKGMGR_SERVER(29179): pkgmgr-server.c: __get_type_from_msg(283) > [0;31m[__get_type_from_msg(): 283](pkgtype == NULL) pkgtype is null for org.tizen.local 
06-22 06:00:52.104+0900 E/PKGMGR_SERVER(29179): [0;m
06-22 06:00:52.274+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: start, val: update
06-22 06:00:52.274+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [start], Value = [update], install = [1]
06-22 06:00:52.284+0900 W/AUL_AMD (  447): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
06-22 06:00:52.294+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 30
06-22 06:00:52.294+0900 I/Tizen::App(  978): (119) > InstallationInProgress [30]
06-22 06:00:52.294+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [30], install = [1]
06-22 06:00:52.294+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:52.294+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:52.304+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:52.304+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:52.324+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:52.324+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:52.324+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:52.324+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:52.964+0900 E/PKGMGR_CERT(29180): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-22 06:00:52.974+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 60
06-22 06:00:52.974+0900 I/Tizen::App(  978): (119) > InstallationInProgress [60]
06-22 06:00:52.974+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [60], install = [1]
06-22 06:00:52.974+0900 E/PKGMGR_CERT(29180): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 88
06-22 06:00:52.974+0900 E/PKGMGR_CERT(29180): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 88
06-22 06:00:52.974+0900 E/PKGMGR_CERT(29180): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 1
06-22 06:00:52.974+0900 E/PKGMGR_CERT(29180): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 1
06-22 06:00:52.974+0900 E/PKGMGR_CERT(29180): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 1
06-22 06:00:52.974+0900 E/PKGMGR_CERT(29180): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 1
06-22 06:00:52.994+0900 E/PKGMGR_CERT(29180): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
06-22 06:00:52.994+0900 E/rpm-installer(29180): coretpk-installer.c: _coretpk_installer_make_directory(1784) > mkdir failed. appdir=[/usr/apps/org.tizen.local/shared], errno=[2][No such file or directory]
06-22 06:00:52.994+0900 E/rpm-installer(29180): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared]
06-22 06:00:52.994+0900 E/rpm-installer(29180): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/opt/usr/apps/org.tizen.local/shared/data]
06-22 06:00:52.994+0900 E/rpm-installer(29180): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared/res]
06-22 06:00:52.994+0900 E/rpm-installer(29180): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/tizen-manifest.xml]
06-22 06:00:52.994+0900 E/rpm-installer(29180): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/author-signature.xml]
06-22 06:00:52.994+0900 E/rpm-installer(29180): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/signature1.xml]
06-22 06:00:52.994+0900 E/rpm-installer(29180): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/share/packages/org.tizen.local.xml]
06-22 06:00:53.174+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:53.174+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:53.174+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:53.174+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:53.234+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:53.234+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:53.234+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:53.234+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:53.464+0900 E/rpm-installer(29180): coretpk-installer.c: _coretpk_installer_get_smack_label_access(964) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.local/shared/data]))
06-22 06:00:54.594+0900 E/PKGMGR_INFO(29180): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-22 06:00:54.594+0900 E/PKGMGR_INSTALLER(29180): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-22 06:00:54.604+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: OnClientListenCb(535) >  #Step 1
06-22 06:00:54.604+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 2
06-22 06:00:54.604+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-22 06:00:54.614+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 100
06-22 06:00:54.614+0900 I/Tizen::App(  978): (119) > InstallationInProgress [100]
06-22 06:00:54.614+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [100], install = [1]
06-22 06:00:54.614+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: end, val: ok
06-22 06:00:54.614+0900 I/Tizen::App(  978): (78) > Installation is Completed. [Package = org.tizen.local]
06-22 06:00:54.614+0900 I/Tizen::App(  978): (663) > Enter. package(org.tizen.local), installationResult(0)
06-22 06:00:54.634+0900 I/Tizen::App(  978): (1360) > package(org.tizen.local), version(1.0.0), type(rpm), displayName(local), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.local), storeClient(), appRootPath(/opt/usr/apps/org.tizen.local)
06-22 06:00:54.664+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.local]
06-22 06:00:54.664+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(365) >  ##### [org.tizen.local]
06-22 06:00:54.664+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(369) >  END
06-22 06:00:54.664+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _DoPkgJob(448) >  #Step 3 size[1]
06-22 06:00:54.664+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _DoPkgJob(452) >  appId[org.tizen.local]
06-22 06:00:54.674+0900 I/Tizen::App(  978): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.local]
06-22 06:00:54.694+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppInfo(941) >  AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-22 06:00:54.694+0900 I/Tizen::App(  978): (416) > appName = [local]
06-22 06:00:54.694+0900 I/Tizen::App(  978): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-22 06:00:54.694+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: GetAppInfo(595) >  Find a App Info AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-22 06:00:54.694+0900 E/PKGMGR_INFO(  978): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-22 06:00:54.694+0900 I/Tizen::App(  978): (675) > Application count(1) in this package
06-22 06:00:54.694+0900 I/Tizen::App(  978): (855) > Enter.
06-22 06:00:54.704+0900 I/Tizen::App(  978): (416) > appName = [local]
06-22 06:00:54.704+0900 I/Tizen::App(  978): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-22 06:00:54.704+0900 I/Tizen::App(  978): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.local.info]
06-22 06:00:54.704+0900 I/Tizen::App(  978): (131) > Enter
06-22 06:00:54.714+0900 I/Tizen::App(  978): (695) > Exit.
06-22 06:00:54.714+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [end], Value = [ok], install = [1]
06-22 06:00:54.714+0900 I/Tizen::App(  978): (137) > org.tizen.local does not have launch condition
06-22 06:00:54.714+0900 I/Tizen::App(  978): (898) > Exit.
06-22 06:00:56.424+0900 W/AUL_AMD (  447): amd_request.c: __request_handler(601) > __request_handler: 0
06-22 06:00:56.434+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-22 06:00:56.444+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-22 06:00:56.444+0900 E/AUL_AMD (  447): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-22 06:00:56.574+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: ui_app_main(699) > app_efl_main
06-22 06:00:56.604+0900 I/UXT     (29244): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-22 06:00:56.644+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-22 06:00:56.674+0900 E/RESOURCED(  758): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 380
06-22 06:00:56.694+0900 I/Tizen::App(  993): (733) > Finished invoking application event listener for org.tizen.local, 29244.
06-22 06:00:56.704+0900 I/Tizen::App(  978): (499) > LaunchedApp(org.tizen.local)
06-22 06:00:56.714+0900 I/Tizen::App(  978): (733) > Finished invoking application event listener for org.tizen.local, 29244.
06-22 06:00:56.824+0900 E/EFL     (29244): elementary<29244> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b8dbb0 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-22 06:00:56.834+0900 E/EFL     (29244): evas_main<29244> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-22 06:00:56.854+0900 E/EFL     (29244): evas_main<29244> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-22 06:00:56.864+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-22 06:00:56.874+0900 I/APP_CORE(29244): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-22 06:00:56.874+0900 I/APP_CORE(29244): appcore-efl.c: __do_app(511) > [APP 29244] Initial Launching, call the resume_cb
06-22 06:00:56.874+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-22 06:00:56.914+0900 W/APP_CORE(29244): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5000002
06-22 06:00:56.914+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=29244
06-22 06:00:56.964+0900 I/MALI    (  621): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb20362b8] swap changed from sync to async
06-22 06:00:57.014+0900 I/Tizen::System(  993): (259) > Active app [org.tizen.], current [com.samsun] 
06-22 06:00:57.014+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 06:00:57.034+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 06:00:57.054+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-22 06:00:57.054+0900 E/cluster-home(  621): homescreen-main.cpp: app_pause(355) >  app pause
06-22 06:00:57.064+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 06:00:57.064+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 06:00:58.024+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.024+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.024+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.024+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.024+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:58.084+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.084+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.084+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.084+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:58.154+0900 E/EFL     (29244): elementary<29244> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7c19f48 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-22 06:00:58.204+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.204+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.204+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.204+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:00:58.474+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:58.524+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:59.104+0900 E/EFL     (29244): elementary<29244> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b8ff70 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-22 06:00:59.944+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:59.944+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:59.944+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:59.944+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:00:59.944+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:00.304+0900 I/PRIVACY-MANAGER-CLIENT(29244): PrivacyChecker.cpp: initialize(174) > Got lock. Starting initialize
06-22 06:01:00.304+0900 I/PRIVACY-MANAGER-CLIENT(29244): PrivacyChecker.cpp: runSignalListenerThread(204) > Running g main loop for signal
06-22 06:01:00.304+0900 I/PRIVACY-MANAGER-CLIENT(29244): PrivacyChecker.cpp: initializeDbus(230) > Starting initialize
06-22 06:01:00.324+0900 I/PRIVACY-MANAGER-CLIENT(29244): PrivacyChecker.cpp: initializeDbus(245) > Initialized
06-22 06:01:00.324+0900 I/PRIVACY-MANAGER-CLIENT(29244): PrivacyChecker.cpp: initialize(192) > Initialized
06-22 06:01:00.334+0900 W/LOCATION(29244): module-internal.c: module_is_supported(282) > module name(gps) is found
06-22 06:01:00.354+0900 W/LOCATION(29244): module-internal.c: module_new(253) > module (gps) open success
06-22 06:01:00.374+0900 W/LOCATION(29244): module-internal.c: module_is_supported(282) > module name(wps) is found
06-22 06:01:00.394+0900 W/LOCATION(29244): module-internal.c: module_new(253) > module (wps) open success
06-22 06:01:00.664+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:00.664+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:00.664+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:00.664+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:01.024+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.024+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.024+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.024+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:01.084+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.084+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.084+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.084+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:01.324+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.324+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.324+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.324+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:01.444+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.444+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.444+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:01.444+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.804+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.804+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.804+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.804+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:01.864+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.864+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:01.864+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:01.874+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.224+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.224+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.224+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.224+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:02.284+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.284+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.284+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.284+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:02.464+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.464+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.464+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.464+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:02.524+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.524+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.524+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.524+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:02.584+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.584+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.584+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.584+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:02.644+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.644+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.644+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.644+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:02.704+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.704+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.704+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.704+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:02.884+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.884+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.884+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:02.884+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:03.004+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:03.004+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:03.004+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:03.004+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:03.624+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 06:01:03.624+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 06:01:03.624+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 06:01:03.624+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 06:01:03.624+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 06:01:03.624+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 06:01:03.644+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 06:01:03.644+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 06:01:03.764+0900 E/LOCATION(29244): location-hybrid.c: location_hybrid_get_position_ext(781) > There is invalid data.
06-22 06:01:03.764+0900 E/CAPI_LOCATION_MANAGER(29244): locations.c: __convert_error_code(68) > LOCATIONS_ERROR_SERVICE_NOT_AVAILABLE(0xfd400003) : core fw error(0x2)
06-22 06:01:03.764+0900 D/local   (29244): lat = 37.279138, lon = 127.044634
06-22 06:01:03.844+0900 I/CAPI_APPFW_APPLICATION(19067): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:03.844+0900 I/CAPI_APPFW_APPLICATION(26999): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:03.844+0900 I/CAPI_APPFW_APPLICATION( 3729): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:03.844+0900 W/CAM_APP (19067): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-22 06:01:04.334+0900 E/EFL     (29244): elementary<29244> elm_map.c:6740 elm_map_overlay_region_get() Not supported overlay type: -1211124904
06-22 06:01:04.334+0900 D/local   (29244): new lat = 37.279138, lon = 127.044634
06-22 06:01:04.414+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.444+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.464+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.524+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.544+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.554+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-22 06:01:04.584+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.624+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.624+0900 W/LOCATION(29244): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 06:01:04.624+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 06:01:04.624+0900 W/LOCATION(29244): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 06:01:04.634+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 06:01:04.644+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.684+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.704+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.724+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.744+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.764+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.794+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.814+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.834+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:04.864+0900 I/CAPI_APPFW_APPLICATION(29244): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-22 06:01:08.304+0900 E/EFL     (29244): elementary<29244> elm_map.c:1248 _mouse_up_cb() Mouse up!!!!!
06-22 06:01:09.674+0900 E/EFL     (29244): elementary<29244> elm_map.c:1248 _mouse_up_cb() Mouse up!!!!!
06-22 06:01:12.074+0900 E/EFL     (29244): elementary<29244> elm_map.c:6740 elm_map_overlay_region_get() Not supported overlay type: -1211124904
06-22 06:01:12.074+0900 D/local   (29244): changed lat = 6431720581394319227418075555976416116070364409212387073382806459883301854715631743105060831317751295237567828298414238088160357909188614969403659719267597186066028996123519953871219471011237127235589900898649971137729524124773715680660308923402693500998131312142050241019904.000000, lon = -0.000000
06-22 06:01:12.214+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 06:01:12.214+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 06:01:12.254+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(142) > dead_pid = 29244 pgid = 29244
06-22 06:01:12.254+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(123) > dead_pid(29244)
06-22 06:01:12.254+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-22 06:01:12.254+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-22 06:01:12.304+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-22 06:01:12.314+0900 I/Tizen::System(  993): (246) > Terminated app [org.tizen.local]
06-22 06:01:12.314+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 06:01:12.314+0900 I/Tizen::App(  978): (243) > App[org.tizen.local] pid[29244] terminate event is forwarded
06-22 06:01:12.314+0900 I/Tizen::System(  978): (256) > osp.accessorymanager.service provider is found.
06-22 06:01:12.314+0900 I/Tizen::System(  978): (196) > Accessory Owner is removed [org.tizen.local, 29244, ]
06-22 06:01:12.314+0900 I/Tizen::System(  978): (256) > osp.system.service provider is found.
06-22 06:01:12.314+0900 I/Tizen::App(  978): (506) > TerminatedApp(org.tizen.local)
06-22 06:01:12.314+0900 I/Tizen::App(  978): (512) > Not registered pid(29244)
06-22 06:01:12.314+0900 I/Tizen::App(  978): (782) > Finished invoking application event listener for org.tizen.local, 29244.
06-22 06:01:12.324+0900 I/AUL_AMD (  447): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 29244
06-22 06:01:12.334+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-22 06:01:12.334+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-22 06:01:12.384+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_create(363) > New handle created[0xb7b627f0]
06-22 06:01:12.384+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_get_type(412) > Connected Network = 2
06-22 06:01:12.384+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_destroy(379) > Destroy handle: 0xb7b627f0
06-22 06:01:12.394+0900 E/weather-live(26999): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
06-22 06:01:12.394+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_create(363) > New handle created[0xb7d1d510]
06-22 06:01:12.404+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_get_type(412) > Connected Network = 2
06-22 06:01:12.404+0900 I/CAPI_NETWORK_CONNECTION(26999): connection.c: connection_destroy(379) > Destroy handle: 0xb7d1d510
06-22 06:01:12.414+0900 E/weather-live(26999): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 06:01:12.434+0900 W/CRASH_MANAGER(29301): worker.c: worker_job(1198) > 11292446c6f63143492047
