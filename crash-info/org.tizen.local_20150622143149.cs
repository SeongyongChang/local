S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: local
PID: 9651
Date: 2015-06-22 14:31:49+0900
Executable File Path: /opt/usr/apps/org.tizen.local/bin/local
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x9c000000

Register Information
r0   = 0x9c000000, r1   = 0x9c000000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb4d96437
r6   = 0xbeda9868, r7   = 0x9c000000
r8   = 0x0000001a, r9   = 0xb653a4d0
r10  = 0xb4d9641c, fp   = 0xbeda985c
ip   = 0x00000000, sp   = 0xbeda92f8
lr   = 0xb6c5c5b8, pc   = 0xb6c8fd64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     55656 KB
Buffers:     56616 KB
Cached:     245840 KB
VmPeak:     109232 KB
VmSize:     105064 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23444 KB
VmRSS:       23440 KB
VmData:      52204 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       24724 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9651 TID = 9651
9651 9743 9744 

Maps Information
b1101000 b1900000 rwxp [stack:9743]
b1b01000 b2300000 rwxp [stack:9744]
b4311000 b4318000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.55
b4320000 b4322000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b432a000 b432d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b4340000 b4342000 r-xp /usr/lib/location/module/libwps.so.0.0.0
b434a000 b434d000 r-xp /usr/lib/location/module/libgps.so.0.0.0
b435c000 b4361000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/linux-gnueabi-armv7l-1.7.99/module.so
b4369000 b4379000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b437a000 b437f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
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
b7a3f000 b808f000 rw-p [heap]
bed8a000 bedab000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9651)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6c8fd64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6c5c5b8) [/lib/libc.so.6] + 0x3f5b8
 2: vsprintf + 0x64 (0xb6c79944) [/lib/libc.so.6] + 0x5c944
 3: sprintf + 0x1c (0xb6c631fc) [/lib/libc.so.6] + 0x461fc
 4: clicked_submit_btn_cb + 0x118 (0xb4d94fb1) [/opt/usr/apps/org.tizen.local/bin/local] + 0x2fb1
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
) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: vconf_get_int(2379) > vconf_get_int(504) : db/ise/swiftkey/dlm/onpause_noti error
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
06-22 14:31:29.141+0900 E/VCONF   (  504): vconf.c: vconf_get_int(2379) > vconf_get_int(504) : db/ise/swiftkey/dlm/onpause_noti error
06-22 14:31:29.141+0900 I/ISE_MULTI(  504): isemain.cpp: slot_update_cursor_position(868) > [0;36m[hidden state:false] pos=0[0m
06-22 14:31:29.201+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:29.221+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=504
06-22 14:31:29.281+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xe0 value =0x0[0m
06-22 14:31:29.281+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0xe0[0m
06-22 14:31:29.311+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-22 14:31:29.311+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-22 14:31:29.311+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x200 value =0x0[0m
06-22 14:31:29.311+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x200[0m
06-22 14:31:29.311+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:29.311+0900 W/IME_LITE(  479): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
06-22 14:31:29.321+0900 W/IME_LITE(  479): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff02 value =0x1[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff03 value =0x1[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff04 value =0x1[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff05 value =0x1[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff06 value =0x0[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff07 value =0x1[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff08 value =0x1[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff09 value =0x0[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff0a value =0x1[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): selectpage.cpp: ResetSelection(28) > [0;36m[0m
06-22 14:31:29.321+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-22 14:31:29.351+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 14:31:29.351+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 14:31:29.381+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x1400002 FAILED!
06-22 14:31:29.381+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x1400002 FAILED!
06-22 14:31:29.391+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:false][0m
06-22 14:31:29.451+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-22 14:31:30.521+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-22 14:31:30.521+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-22 14:31:30.521+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-22 14:31:30.521+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 1[0m
06-22 14:31:30.531+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.561+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:30.571+0900 I/ISE_MULTI(  504): isemain.cpp: slot_set_caps_mode(806) > [0;36m[hidden state:false] mode=0[0m
06-22 14:31:30.571+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:30.571+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:30.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-22 14:31:30.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-22 14:31:30.771+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-22 14:31:30.771+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-22 14:31:30.771+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:30.821+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:30.831+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:36.681+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:36.731+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:false][0m
06-22 14:31:36.731+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-22 14:31:36.771+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:36.791+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-22 14:31:36.791+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0xe00002 FAILED!
06-22 14:31:36.861+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9651
06-22 14:31:37.471+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:37.471+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:37.471+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:37.471+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:true][0m
06-22 14:31:37.471+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:37.481+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0xe00002 FAILED!
06-22 14:31:37.481+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0xe00002 FAILED!
06-22 14:31:37.481+0900 I/ISE_MULTI(  504): isemain.cpp: slot_set_caps_mode(806) > [0;36m[hidden state:true] mode=1[0m
06-22 14:31:37.481+0900 I/ISE_MULTI(  504): isemain.cpp: slot_update_cursor_position(868) > [0;36m[hidden state:true] pos=0[0m
06-22 14:31:37.491+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff02 value =0x1[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff03 value =0x1[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff04 value =0x1[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff05 value =0x1[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff06 value =0x0[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff07 value =0x1[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff08 value =0x1[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff09 value =0x0[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff0a value =0x1[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): selectpage.cpp: ResetSelection(28) > [0;36m[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xe0 value =0x0[0m
06-22 14:31:37.501+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0xe0[0m
06-22 14:31:37.501+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-22 14:31:37.521+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:37.521+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:37.521+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x200 value =0x0[0m
06-22 14:31:37.531+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x200[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:37.531+0900 W/IME_LITE(  479): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
06-22 14:31:37.531+0900 W/IME_LITE(  479): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff02 value =0x1[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff03 value =0x1[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff04 value =0x1[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff05 value =0x1[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff06 value =0x0[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff07 value =0x1[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff08 value =0x1[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff09 value =0x0[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0xff0a value =0x1[0m
06-22 14:31:37.531+0900 I/IME_LITE(  479): selectpage.cpp: ResetSelection(28) > [0;36m[0m
06-22 14:31:37.551+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-22 14:31:37.551+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/use_on) step(-21) failed(2 / No such file or directory)
06-22 14:31:37.551+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/use_on : read buf error(-21). break
06-22 14:31:37.551+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/ise/swiftkey/dlm/use_on error
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: vconf_get_int(2379) > vconf_get_int(504) : db/ise/swiftkey/dlm/onpause_noti error
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: vconf_get_bool(2417) > vconf_get_bool(504) : db/setting/homescreen/easymode error
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
06-22 14:31:37.561+0900 E/VCONF   (  504): vconf.c: vconf_get_int(2379) > vconf_get_int(504) : db/ise/swiftkey/dlm/onpause_noti error
06-22 14:31:37.571+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:false][0m
06-22 14:31:37.581+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x1[0m
06-22 14:31:37.621+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=504
06-22 14:31:37.691+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 14:31:37.691+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 14:31:37.731+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x1400002 FAILED!
06-22 14:31:37.731+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x1400002 FAILED!
06-22 14:31:38.541+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-22 14:31:38.541+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-22 14:31:38.541+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-22 14:31:38.541+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 1[0m
06-22 14:31:38.551+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.591+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:38.621+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:38.631+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:38.641+0900 I/ISE_MULTI(  504): isemain.cpp: slot_set_caps_mode(806) > [0;36m[hidden state:false] mode=0[0m
06-22 14:31:38.641+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-22 14:31:38.641+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-22 14:31:38.691+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-22 14:31:38.691+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-22 14:31:38.691+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.781+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:38.801+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:38.801+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-22 14:31:38.801+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-22 14:31:38.801+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.841+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:38.851+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:38.871+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x400 value =0xffffffff[0m
06-22 14:31:38.871+0900 E/IME_LITE(  479): isf_xt9_imengine.cpp: process_helper_event(1584) > [0;31munknow cmd=0x400[0m
06-22 14:31:38.871+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(499) > [0;33mret : 41[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 E/IME_LITE(  479): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
06-22 14:31:38.891+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:38.911+0900 W/IME_LITE(  479): isf_xt9_imengine.cpp: process_key_event(532) > [0;33mret = 0[0m
06-22 14:31:40.991+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:40.991+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:false][0m
06-22 14:31:41.001+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-22 14:31:41.021+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:41.051+0900 W/ISF_PANEL_EFL(  501): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0xe00002 FAILED!
06-22 14:31:41.061+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9651
06-22 14:31:41.101+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x30 value =0x0[0m
06-22 14:31:41.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:41.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:41.711+0900 I/IME_LITE(  479): westerneuropeandusxt9.cpp: _HelperCommandEvent(437) > [0;36mcmd = 0x90 value =0x0[0m
06-22 14:31:41.711+0900 I/ISE_MULTI(  504): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:true][0m
06-22 14:31:41.731+0900 I/PRIVACY-MANAGER-CLIENT( 9651): PrivacyChecker.cpp: initialize(174) > Got lock. Starting initialize
06-22 14:31:41.731+0900 I/PRIVACY-MANAGER-CLIENT( 9651): PrivacyChecker.cpp: runSignalListenerThread(204) > Running g main loop for signal
06-22 14:31:41.731+0900 I/PRIVACY-MANAGER-CLIENT( 9651): PrivacyChecker.cpp: initializeDbus(230) > Starting initialize
06-22 14:31:41.751+0900 I/PRIVACY-MANAGER-CLIENT( 9651): PrivacyChecker.cpp: initializeDbus(245) > Initialized
06-22 14:31:41.751+0900 I/PRIVACY-MANAGER-CLIENT( 9651): PrivacyChecker.cpp: initialize(192) > Initialized
06-22 14:31:41.751+0900 W/LOCATION( 9651): module-internal.c: module_is_supported(282) > module name(gps) is found
06-22 14:31:41.771+0900 W/LOCATION( 9651): module-internal.c: module_new(253) > module (gps) open success
06-22 14:31:41.791+0900 W/LOCATION( 9651): module-internal.c: module_is_supported(282) > module name(wps) is found
06-22 14:31:41.801+0900 W/LOCATION( 9651): module-internal.c: module_new(253) > module (wps) open success
06-22 14:31:45.031+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:31:45.031+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:31:45.031+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:31:45.031+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:31:45.031+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:31:45.031+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:31:45.051+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:31:45.051+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:31:45.171+0900 E/LOCATION( 9651): location-hybrid.c: location_hybrid_get_position_ext(781) > There is invalid data.
06-22 14:31:45.171+0900 E/CAPI_LOCATION_MANAGER( 9651): locations.c: __convert_error_code(68) > LOCATIONS_ERROR_SERVICE_NOT_AVAILABLE(0xfd400003) : core fw error(0x2)
06-22 14:31:45.171+0900 D/local   ( 9651): lat = 37.283655, lon = 127.044696
06-22 14:31:45.981+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-22 14:31:46.071+0900 E/EFL     ( 9651): ecore<9651> ecore_main.c:414 _ecore_main_fdh_poll_del() Failed to delete epoll fd 46! (errno=1)
06-22 14:31:46.071+0900 E/EFL     ( 9651): ecore<9651> ecore_main.c:414 _ecore_main_fdh_poll_del() Failed to delete epoll fd 47! (errno=1)
06-22 14:31:46.131+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:31:46.131+0900 W/LOCATION( 9651): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:31:46.131+0900 W/LOCATION( 9651): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:31:46.141+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:31:47.981+0900 E/EFL     ( 9651): elementary<9651> elm_map.c:1248 _mouse_up_cb() Mouse up!!!!!
06-22 14:31:48.301+0900 E/EFL     ( 9651): elementary<9651> elm_map.c:1248 _mouse_up_cb() Mouse up!!!!!
06-22 14:31:48.391+0900 D/local   ( 9651): map changed lat = 37.281395, lon = 127.044654
06-22 14:31:48.461+0900 E/EFL     ( 9651): elementary<9651> elm_map.c:1248 _mouse_up_cb() Mouse up!!!!!
06-22 14:31:49.971+0900 D/local   ( 9651): submit button pressed
06-22 14:31:50.131+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 14:31:50.131+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 14:31:50.161+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(142) > dead_pid = 9651 pgid = 9651
06-22 14:31:50.161+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(123) > dead_pid(9651)
06-22 14:31:50.161+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-22 14:31:50.161+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-22 14:31:50.211+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-22 14:31:50.221+0900 I/Tizen::System(  993): (246) > Terminated app [org.tizen.local]
06-22 14:31:50.221+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 14:31:50.221+0900 I/Tizen::App(  978): (243) > App[org.tizen.local] pid[9651] terminate event is forwarded
06-22 14:31:50.221+0900 I/Tizen::System(  978): (256) > osp.accessorymanager.service provider is found.
06-22 14:31:50.221+0900 I/Tizen::System(  978): (196) > Accessory Owner is removed [org.tizen.local, 9651, ]
06-22 14:31:50.221+0900 I/Tizen::System(  978): (256) > osp.system.service provider is found.
06-22 14:31:50.221+0900 I/Tizen::App(  978): (506) > TerminatedApp(org.tizen.local)
06-22 14:31:50.221+0900 I/Tizen::App(  978): (512) > Not registered pid(9651)
06-22 14:31:50.221+0900 I/Tizen::App(  978): (782) > Finished invoking application event listener for org.tizen.local, 9651.
06-22 14:31:50.221+0900 I/AUL_AMD (  447): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 9651
06-22 14:31:50.241+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 14:31:50.241+0900 I/Tizen::App(  993): (782) > Finished invoking application event listener for org.tizen.local, 9651.
06-22 14:31:50.241+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-22 14:31:50.241+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-22 14:31:50.301+0900 I/Tizen::System(  993): (259) > Active app [com.samsun], current [org.tizen.] 
06-22 14:31:50.301+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 14:31:50.321+0900 W/CRASH_MANAGER( 9778): worker.c: worker_job(1198) > 11096516c6f63143495110
