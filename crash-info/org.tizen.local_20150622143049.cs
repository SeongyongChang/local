S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: local
PID: 9373
Date: 2015-06-22 14:30:49+0900
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
MemFree:     55504 KB
Buffers:     56596 KB
Cached:     245656 KB
VmPeak:     110428 KB
VmSize:     105276 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23696 KB
VmRSS:       23692 KB
VmData:      52416 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       24724 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9373 TID = 9373
9373 9427 9430 

Maps Information
b1201000 b1a00000 rwxp [stack:9427]
b1a01000 b2200000 rwxp [stack:9430]
b42c5000 b42cc000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.55
b42d4000 b42d6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b42de000 b42e1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
b42f4000 b42f6000 r-xp /usr/lib/location/module/libwps.so.0.0.0
b42fe000 b4301000 r-xp /usr/lib/location/module/libgps.so.0.0.0
b4310000 b4315000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/linux-gnueabi-armv7l-1.7.99/module.so
b431d000 b432d000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b432e000 b4333000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
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
b7a3f000 b7ebb000 rw-p [heap]
bed8a000 bedab000 rwxp [stack]
bed8a000 bedab000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9373)
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
/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:28:54.891+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:28:54.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:28:54.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:28:54.891+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:28:54.911+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:28:54.911+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:28:55.771+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-22 14:28:55.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:28:55.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:28:55.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:28:55.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:28:55.881+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:28:55.881+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:09.881+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:29:09.881+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:29:09.881+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:29:09.881+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:29:09.881+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:29:09.881+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:29:09.901+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:09.901+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:10.761+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-22 14:29:10.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:10.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:10.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:10.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:10.891+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:10.901+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:24.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:29:24.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:29:24.891+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:29:24.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:29:24.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:29:24.891+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:29:24.911+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:24.911+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:25.761+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-22 14:29:25.901+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:25.901+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:25.901+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:25.901+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:25.911+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:25.921+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:37.491+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 14:29:37.491+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 14:29:37.581+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-22 14:29:37.641+0900 I/Tizen::System(  993): (259) > Active app [com.samsun], current [org.tizen.] 
06-22 14:29:37.641+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 14:29:37.651+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 14:29:37.661+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-22 14:29:37.661+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-22 14:29:37.671+0900 W/AUL_AMD (  447): amd_request.c: __request_handler(601) > __request_handler: 0
06-22 14:29:37.681+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
06-22 14:29:37.691+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
06-22 14:29:37.691+0900 E/AUL_AMD (  447): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-22 14:29:37.791+0900 I/CAPI_APPFW_APPLICATION( 5307): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-22 14:29:37.841+0900 I/CAPI_APPFW_APPLICATION( 8996): app_main.c: ui_app_main(699) > app_efl_main
06-22 14:29:37.891+0900 I/UXT     ( 8996): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-22 14:29:37.931+0900 I/Tizen::App(  978): (499) > LaunchedApp(com.samsung.data-provider-slave)
06-22 14:29:37.931+0900 I/Tizen::App(  978): (733) > Finished invoking application event listener for com.samsung.data-provider-slave, 8996.
06-22 14:29:37.941+0900 E/RESOURCED(  758): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 370
06-22 14:29:37.951+0900 I/Tizen::App(  993): (733) > Finished invoking application event listener for com.samsung.data-provider-slave, 8996.
06-22 14:29:38.001+0900 I/CAPI_APPFW_APPLICATION( 8996): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-22 14:29:38.041+0900 I/EFL-ASSIST( 8996): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b7aac7f0) from (/usr/share/themes/FontInfoTable.xml) is created
06-22 14:29:38.041+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8996): system_settings.c: system_settings_set_changed_cb(541) > b4d4b1fd
06-22 14:29:38.041+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8996): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_size --- callback ptr : b4d49dfd
06-22 14:29:38.041+0900 E/EFL     ( 8996): evas_main<8996> evas_font_dir.c:1515 evas_font_reinit() ENTER:: evas_font_reinit
06-22 14:29:38.061+0900 E/EFL     ( 8996): evas_main<8996> evas_font_dir.c:1526 evas_font_reinit() DONE:: evas_font_reinit
06-22 14:29:38.071+0900 I/EFL-ASSIST( 8996): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b7abd078) from (/opt/usr/share/data-provider-slave/theme/color/com.samsung.data-provider-slave_ChangeableColorInfo.xml) is created
06-22 14:29:38.081+0900 E/EFL-ASSIST( 8996): efl_assist_theme_color.cpp: ea_theme_colors_set(868) > cannot get color table data
06-22 14:29:38.081+0900 I/CAPI_APPFW_APPLICATION( 8996): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-22 14:29:38.111+0900 I/APP_CORE( 8996): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-22 14:29:38.111+0900 I/APP_CORE( 8996): appcore-efl.c: __do_app(511) > [APP 8996] Initial Launching, call the resume_cb
06-22 14:29:38.111+0900 I/CAPI_APPFW_APPLICATION( 8996): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-22 14:29:38.341+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_create(363) > New handle created[0xb7b0b108]
06-22 14:29:38.341+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: __connection_set_type_changed_callback(146) > Successfully registered(1)
06-22 14:29:38.341+0900 E/weather-common( 8996): dbf-engine-db.c: dbf_engine_db_initialize(66) > [0;40;31mp_db_handle is NULL[0;m
06-22 14:29:38.361+0900 E/cluster-home(  621): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-22 14:29:38.361+0900 E/cluster-home(  621): cluster-data-list.cpp: UpdateCustomDBox(1485) >  Invalid box size: 65535
06-22 14:29:38.361+0900 W/cluster-home(  621): cluster-data-provider.cpp: DBoxEventUpdated(1657) >  Can not update dynamicbox
06-22 14:29:38.371+0900 E/weather-live( 8996): main.c: dynamicbox_resize(1813) > [0;40;31minfo->first_create : 0[0;m
06-22 14:29:38.401+0900 E/EFL     ( 8996): evas_main<8996> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-22 14:29:38.401+0900 E/EFL     ( 8996): evas_main<8996> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-22 14:29:38.441+0900 E/weather-live( 8996): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 14:29:38.591+0900 E/weather-live( 8996): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-22 14:29:38.591+0900 E/weather-live( 8996): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-22 14:29:38.631+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_create(363) > New handle created[0xb7c724c8]
06-22 14:29:38.631+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_get_type(412) > Connected Network = 2
06-22 14:29:38.631+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_destroy(379) > Destroy handle: 0xb7c724c8
06-22 14:29:38.651+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
06-22 14:29:38.681+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
06-22 14:29:38.721+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-22 14:29:38.741+0900 W/AUL_AMD (  447): amd_request.c: __request_handler(601) > __request_handler: 1
06-22 14:29:38.751+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-22 14:29:38.761+0900 W/AUL_AMD (  447): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 1, pid: 5307
06-22 14:29:38.761+0900 W/AUL_AMD (  447): amd_launch.c: _resume_app(728) > resume done
06-22 14:29:38.781+0900 E/weather-live( 8996): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 14:29:38.791+0900 E/weather-live( 8996): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-22 14:29:38.791+0900 E/weather-live( 8996): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-22 14:29:38.821+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_create(363) > New handle created[0xb7b924c8]
06-22 14:29:38.821+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_get_type(412) > Connected Network = 2
06-22 14:29:38.821+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_destroy(379) > Destroy handle: 0xb7b924c8
06-22 14:29:38.821+0900 W/AUL_AMD (  447): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(31), pid(5307), cmd(3)
06-22 14:29:38.841+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
06-22 14:29:38.881+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
06-22 14:29:38.901+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 14:29:38.901+0900 W/AUL_AMD (  447): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
06-22 14:29:38.911+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-22 14:29:38.921+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-22 14:29:38.951+0900 E/weather-live( 8996): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 14:29:38.971+0900 E/weather-live( 8996): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
06-22 14:29:38.971+0900 E/weather-live( 8996): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
06-22 14:29:39.001+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_create(363) > New handle created[0xb7cf11d0]
06-22 14:29:39.001+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_get_type(412) > Connected Network = 2
06-22 14:29:39.001+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_destroy(379) > Destroy handle: 0xb7cf11d0
06-22 14:29:39.001+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5307
06-22 14:29:39.011+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
06-22 14:29:39.051+0900 I/Tizen::System(  993): (259) > Active app [org.tizen.], current [com.samsun] 
06-22 14:29:39.051+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 14:29:39.051+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-22 14:29:39.051+0900 E/cluster-home(  621): homescreen-main.cpp: app_pause(355) >  app pause
06-22 14:29:39.051+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 14:29:39.071+0900 I/CAPI_APPFW_APPLICATION( 5307): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-22 14:29:39.091+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
06-22 14:29:39.121+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
06-22 14:29:39.151+0900 E/weather-common( 8996): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
06-22 14:29:39.311+0900 E/cluster-home(  621): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-22 14:29:39.321+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_create(363) > New handle created[0xb7cec930]
06-22 14:29:39.321+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_get_type(412) > Connected Network = 2
06-22 14:29:39.321+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_destroy(379) > Destroy handle: 0xb7cec930
06-22 14:29:39.321+0900 E/weather-live( 8996): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
06-22 14:29:39.321+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_create(363) > New handle created[0xb7cf7810]
06-22 14:29:39.321+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_get_type(412) > Connected Network = 2
06-22 14:29:39.321+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_destroy(379) > Destroy handle: 0xb7cf7810
06-22 14:29:39.331+0900 E/cluster-home(  621): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-22 14:29:39.331+0900 E/cluster-home(  621): cluster-data-provider.cpp: EventPixmapAcquired(2075) >  Release depreacted pixmap [27263036]
06-22 14:29:39.331+0900 E/weather-live( 8996): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 14:29:39.351+0900 E/weather-live( 8996): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 14:29:39.371+0900 E/weather-live( 8996): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 14:29:39.391+0900 E/weather-common( 8996): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
06-22 14:29:39.401+0900 E/weather-common( 8996): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
06-22 14:29:39.881+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:29:39.881+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:29:39.881+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:29:39.881+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:29:39.881+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:29:39.881+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:29:39.901+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:39.901+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:40.751+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-22 14:29:40.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:40.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:40.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:40.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:40.881+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:40.881+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:41.831+0900 D/local   ( 5307): submit button pressed
06-22 14:29:41.831+0900 D/local   ( 5307): INSERT INTO LOCAL VALUES('(null)','b','c','d','2015-05-12','e','(null)',NULL);
06-22 14:29:41.841+0900 D/local   ( 5307): -0: 
06-22 14:29:41.841+0900 D/local   ( 5307): COMMENT = (null) | 
06-22 14:29:41.841+0900 D/local   ( 5307): LOCATION_X = b | 
06-22 14:29:41.841+0900 D/local   ( 5307): LOCATION_Y = c | 
06-22 14:29:41.841+0900 D/local   ( 5307): TIME_START = d | 
06-22 14:29:41.841+0900 D/local   ( 5307): TIME_FINISH = 2015-05-12 | 
06-22 14:29:41.841+0900 D/local   ( 5307): TAG = e | 
06-22 14:29:41.841+0900 D/local   ( 5307): TITLE = (null) | 
06-22 14:29:41.841+0900 D/local   ( 5307): KEY = 1 | 
06-22 14:29:41.841+0900 D/local   ( 5307): 
06-22 14:29:41.891+0900 E/EFL     ( 5307): elementary<5307> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7c0f2b8 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-22 14:29:54.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:29:54.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:29:54.891+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:29:54.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:29:54.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:29:54.891+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:29:54.911+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:54.911+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:55.761+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-22 14:29:55.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:55.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:55.891+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:55.891+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:29:55.891+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:29:55.901+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:30:09.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:30:09.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:30:09.891+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:30:09.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:30:09.891+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:30:09.891+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:30:09.911+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:30:09.911+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:30:10.761+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-22 14:30:10.871+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:30:10.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:30:10.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:30:10.881+0900 W/LOCATION( 5307): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:30:10.881+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:30:10.891+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:30:18.741+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(142) > dead_pid = 5307 pgid = 5307
06-22 14:30:18.741+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(123) > dead_pid(5307)
06-22 14:30:18.741+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-22 14:30:18.741+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-22 14:30:18.741+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 14:30:18.741+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 14:30:18.811+0900 I/Tizen::System(  993): (246) > Terminated app [org.tizen.local]
06-22 14:30:18.811+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 14:30:18.811+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-22 14:30:18.821+0900 I/Tizen::App(  978): (243) > App[org.tizen.local] pid[5307] terminate event is forwarded
06-22 14:30:18.821+0900 I/Tizen::System(  978): (256) > osp.accessorymanager.service provider is found.
06-22 14:30:18.821+0900 I/Tizen::System(  978): (196) > Accessory Owner is removed [org.tizen.local, 5307, ]
06-22 14:30:18.821+0900 I/Tizen::System(  978): (256) > osp.system.service provider is found.
06-22 14:30:18.821+0900 I/Tizen::App(  978): (506) > TerminatedApp(org.tizen.local)
06-22 14:30:18.821+0900 I/Tizen::App(  978): (512) > Not registered pid(5307)
06-22 14:30:18.821+0900 I/Tizen::App(  978): (782) > Finished invoking application event listener for org.tizen.local, 5307.
06-22 14:30:18.821+0900 I/AUL_AMD (  447): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 5307
06-22 14:30:18.841+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 14:30:18.841+0900 I/Tizen::App(  993): (782) > Finished invoking application event listener for org.tizen.local, 5307.
06-22 14:30:18.841+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-22 14:30:18.841+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-22 14:30:18.871+0900 I/Tizen::System(  993): (259) > Active app [com.samsun], current [org.tizen.] 
06-22 14:30:18.871+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 14:30:18.871+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_create(363) > New handle created[0xb7b66e98]
06-22 14:30:18.881+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 14:30:18.881+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_get_type(412) > Connected Network = 2
06-22 14:30:18.881+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_destroy(379) > Destroy handle: 0xb7b66e98
06-22 14:30:18.891+0900 E/weather-live( 8996): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
06-22 14:30:18.891+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_create(363) > New handle created[0xb7b66e68]
06-22 14:30:18.891+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_get_type(412) > Connected Network = 2
06-22 14:30:18.891+0900 I/CAPI_NETWORK_CONNECTION( 8996): connection.c: connection_destroy(379) > Destroy handle: 0xb7b66e68
06-22 14:30:18.901+0900 E/weather-live( 8996): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 14:30:18.951+0900 E/weather-live( 8996): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 14:30:18.961+0900 E/weather-live( 8996): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-22 14:30:18.991+0900 E/weather-common( 8996): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
06-22 14:30:18.991+0900 E/weather-common( 8996): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
06-22 14:30:19.001+0900 E/cluster-home(  621): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-22 14:30:19.821+0900 E/libgps_d(19743): [proxy__gps_stop][line = 1057]: stop failed error(-1)
06-22 14:30:19.821+0900 E/CAPI_LOCATION_MANAGER(  929): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
06-22 14:30:19.971+0900 E/CAPI_LOCATION_MANAGER(  929): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
06-22 14:30:21.201+0900 I/MALI    (  621): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb20362b8] swap changed from async to sync
06-22 14:30:22.321+0900 E/PKGMGR  ( 9302): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.local]
06-22 14:30:22.321+0900 E/PKGMGR_SERVER( 9302): pkgmgr-server.c: __get_type_from_msg(283) > [0;31m[__get_type_from_msg(): 283](pkgtype == NULL) pkgtype is null for org.tizen.local 
06-22 14:30:22.321+0900 E/PKGMGR_SERVER( 9302): [0;m
06-22 14:30:22.501+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: start, val: update
06-22 14:30:22.501+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [start], Value = [update], install = [1]
06-22 14:30:22.501+0900 W/AUL_AMD (  447): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
06-22 14:30:22.511+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 30
06-22 14:30:22.511+0900 I/Tizen::App(  978): (119) > InstallationInProgress [30]
06-22 14:30:22.511+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [30], install = [1]
06-22 14:30:23.191+0900 E/PKGMGR_CERT( 9305): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-22 14:30:23.191+0900 E/PKGMGR_CERT( 9305): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 88
06-22 14:30:23.191+0900 E/PKGMGR_CERT( 9305): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 88
06-22 14:30:23.191+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 60
06-22 14:30:23.191+0900 I/Tizen::App(  978): (119) > InstallationInProgress [60]
06-22 14:30:23.191+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [60], install = [1]
06-22 14:30:23.191+0900 E/PKGMGR_CERT( 9305): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 1
06-22 14:30:23.191+0900 E/PKGMGR_CERT( 9305): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 1
06-22 14:30:23.201+0900 E/PKGMGR_CERT( 9305): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 1
06-22 14:30:23.201+0900 E/PKGMGR_CERT( 9305): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 1
06-22 14:30:23.221+0900 E/PKGMGR_CERT( 9305): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
06-22 14:30:23.231+0900 E/rpm-installer( 9305): coretpk-installer.c: _coretpk_installer_make_directory(1784) > mkdir failed. appdir=[/usr/apps/org.tizen.local/shared], errno=[2][No such file or directory]
06-22 14:30:23.231+0900 E/rpm-installer( 9305): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared]
06-22 14:30:23.231+0900 E/rpm-installer( 9305): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/opt/usr/apps/org.tizen.local/shared/data]
06-22 14:30:23.231+0900 E/rpm-installer( 9305): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.local/shared/res]
06-22 14:30:23.231+0900 E/rpm-installer( 9305): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/tizen-manifest.xml]
06-22 14:30:23.231+0900 E/rpm-installer( 9305): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/author-signature.xml]
06-22 14:30:23.231+0900 E/rpm-installer( 9305): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.local/signature1.xml]
06-22 14:30:23.231+0900 E/rpm-installer( 9305): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/share/packages/org.tizen.local.xml]
06-22 14:30:23.701+0900 E/rpm-installer( 9305): coretpk-installer.c: _coretpk_installer_get_smack_label_access(964) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.local/shared/data]))
06-22 14:30:24.821+0900 E/PKGMGR_INFO( 9305): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-22 14:30:24.821+0900 E/PKGMGR_INSTALLER( 9305): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-22 14:30:24.831+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: install_percent, val: 100
06-22 14:30:24.831+0900 I/Tizen::App(  978): (119) > InstallationInProgress [100]
06-22 14:30:24.831+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [install_percent], Value = [100], install = [1]
06-22 14:30:24.841+0900 I/Tizen::App(  978): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.local, key: end, val: ok
06-22 14:30:24.841+0900 I/Tizen::App(  978): (78) > Installation is Completed. [Package = org.tizen.local]
06-22 14:30:24.841+0900 I/Tizen::App(  978): (663) > Enter. package(org.tizen.local), installationResult(0)
06-22 14:30:24.841+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: OnClientListenCb(535) >  #Step 1
06-22 14:30:24.841+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 2
06-22 14:30:24.841+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-22 14:30:24.851+0900 I/Tizen::App(  978): (1360) > package(org.tizen.local), version(1.0.0), type(rpm), displayName(local), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.local), storeClient(), appRootPath(/opt/usr/apps/org.tizen.local)
06-22 14:30:24.871+0900 I/Tizen::App(  978): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.local]
06-22 14:30:24.891+0900 I/Tizen::App(  978): (416) > appName = [local]
06-22 14:30:24.891+0900 I/Tizen::App(  978): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-22 14:30:24.901+0900 E/PKGMGR_INFO(  978): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-22 14:30:24.901+0900 I/Tizen::App(  978): (675) > Application count(1) in this package
06-22 14:30:24.901+0900 I/Tizen::App(  978): (855) > Enter.
06-22 14:30:24.911+0900 I/Tizen::App(  978): (695) > Exit.
06-22 14:30:24.911+0900 I/Tizen::App(  978): (1584) > Package = [org.tizen.local], Key = [end], Value = [ok], install = [1]
06-22 14:30:24.921+0900 I/Tizen::App(  978): (416) > appName = [local]
06-22 14:30:24.931+0900 I/Tizen::App(  978): (509) > exe = [/opt/usr/apps/org.tizen.local/bin/local], displayName = [local], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-22 14:30:24.941+0900 I/Tizen::App(  978): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.local.info]
06-22 14:30:24.941+0900 I/Tizen::App(  978): (131) > Enter
06-22 14:30:24.941+0900 I/Tizen::App(  978): (137) > org.tizen.local does not have launch condition
06-22 14:30:24.941+0900 I/Tizen::App(  978): (898) > Exit.
06-22 14:30:24.951+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.local]
06-22 14:30:24.961+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(365) >  ##### [org.tizen.local]
06-22 14:30:24.961+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppIds(369) >  END
06-22 14:30:24.961+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _DoPkgJob(448) >  #Step 3 size[1]
06-22 14:30:24.961+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _DoPkgJob(452) >  appId[org.tizen.local]
06-22 14:30:24.971+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: _GetAppInfo(941) >  AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-22 14:30:24.971+0900 E/cluster-home(  621): mainmenu-package-manager.cpp: GetAppInfo(595) >  Find a App Info AppId[org.tizen.local] Name[local] Icon[/opt/usr/apps/org.tizen.local/shared/res/local.png] enable[1] system[0]
06-22 14:30:26.721+0900 W/AUL_AMD (  447): amd_request.c: __request_handler(601) > __request_handler: 0
06-22 14:30:26.731+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-22 14:30:26.741+0900 I/AUL     (  447): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-22 14:30:26.741+0900 E/AUL_AMD (  447): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-22 14:30:26.831+0900 I/CAPI_APPFW_APPLICATION( 9373): app_main.c: ui_app_main(699) > app_efl_main
06-22 14:30:26.871+0900 E/RESOURCED(  758): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 373
06-22 14:30:26.871+0900 I/UXT     ( 9373): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-22 14:30:26.891+0900 I/Tizen::App(  993): (733) > Finished invoking application event listener for org.tizen.local, 9373.
06-22 14:30:26.891+0900 I/Tizen::App(  978): (499) > LaunchedApp(org.tizen.local)
06-22 14:30:26.891+0900 I/Tizen::App(  978): (733) > Finished invoking application event listener for org.tizen.local, 9373.
06-22 14:30:26.931+0900 I/CAPI_APPFW_APPLICATION( 9373): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-22 14:30:26.961+0900 D/local   ( 9373): -0: 
06-22 14:30:26.961+0900 D/local   ( 9373): COMMENT = (null) | 
06-22 14:30:26.961+0900 D/local   ( 9373): LOCATION_X = b | 
06-22 14:30:26.961+0900 D/local   ( 9373): LOCATION_Y = c | 
06-22 14:30:26.961+0900 D/local   ( 9373): TIME_START = d | 
06-22 14:30:26.961+0900 D/local   ( 9373): TIME_FINISH = 2015-05-12 | 
06-22 14:30:26.961+0900 D/local   ( 9373): TAG = e | 
06-22 14:30:26.961+0900 D/local   ( 9373): TITLE = (null) | 
06-22 14:30:26.961+0900 D/local   ( 9373): KEY = 1 | 
06-22 14:30:26.961+0900 D/local   ( 9373): 
06-22 14:30:27.131+0900 E/EFL     ( 9373): elementary<9373> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b8e128 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-22 14:30:27.151+0900 E/EFL     ( 9373): evas_main<9373> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-22 14:30:27.161+0900 E/EFL     ( 9373): evas_main<9373> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-22 14:30:27.181+0900 I/CAPI_APPFW_APPLICATION( 9373): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-22 14:30:27.191+0900 I/APP_CORE( 9373): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-22 14:30:27.191+0900 I/APP_CORE( 9373): appcore-efl.c: __do_app(511) > [APP 9373] Initial Launching, call the resume_cb
06-22 14:30:27.191+0900 I/CAPI_APPFW_APPLICATION( 9373): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-22 14:30:27.231+0900 W/APP_CORE( 9373): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:e00002
06-22 14:30:27.231+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9373
06-22 14:30:27.311+0900 I/MALI    (  621): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb20362b8] swap changed from sync to async
06-22 14:30:27.341+0900 I/Tizen::System(  993): (259) > Active app [org.tizen.], current [com.samsun] 
06-22 14:30:27.351+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 14:30:27.371+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 14:30:27.381+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 14:30:27.381+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 14:30:27.391+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-22 14:30:27.391+0900 E/cluster-home(  621): homescreen-main.cpp: app_pause(355) >  app pause
06-22 14:30:36.541+0900 E/EFL     ( 9373): elementary<9373> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7c4f970 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-22 14:30:37.391+0900 E/EFL     ( 9373): elementary<9373> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0xb7b904e8 in function: elm_win_resize_object_add, of type: 'elm_grid' when expecting type: 'elm_win'
06-22 14:30:38.231+0900 I/PRIVACY-MANAGER-CLIENT( 9373): PrivacyChecker.cpp: initialize(174) > Got lock. Starting initialize
06-22 14:30:38.241+0900 I/PRIVACY-MANAGER-CLIENT( 9373): PrivacyChecker.cpp: runSignalListenerThread(204) > Running g main loop for signal
06-22 14:30:38.241+0900 I/PRIVACY-MANAGER-CLIENT( 9373): PrivacyChecker.cpp: initializeDbus(230) > Starting initialize
06-22 14:30:38.271+0900 I/PRIVACY-MANAGER-CLIENT( 9373): PrivacyChecker.cpp: initializeDbus(245) > Initialized
06-22 14:30:38.271+0900 I/PRIVACY-MANAGER-CLIENT( 9373): PrivacyChecker.cpp: initialize(192) > Initialized
06-22 14:30:38.271+0900 W/LOCATION( 9373): module-internal.c: module_is_supported(282) > module name(gps) is found
06-22 14:30:38.291+0900 W/LOCATION( 9373): module-internal.c: module_new(253) > module (gps) open success
06-22 14:30:38.311+0900 W/LOCATION( 9373): module-internal.c: module_is_supported(282) > module name(wps) is found
06-22 14:30:38.331+0900 W/LOCATION( 9373): module-internal.c: module_new(253) > module (wps) open success
06-22 14:30:41.551+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:30:41.551+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:30:41.551+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:30:41.551+0900 E/VCONF   (  929): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
06-22 14:30:41.551+0900 E/VCONF   (  929): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
06-22 14:30:41.551+0900 E/VCONF   (  929): vconf.c: vconf_get_int(2379) > vconf_get_int(929) : file/private/wifi/always_allow_scanning error
06-22 14:30:41.581+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:30:41.581+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:30:41.701+0900 E/LOCATION( 9373): location-hybrid.c: location_hybrid_get_position_ext(781) > There is invalid data.
06-22 14:30:41.701+0900 E/CAPI_LOCATION_MANAGER( 9373): locations.c: __convert_error_code(68) > LOCATIONS_ERROR_SERVICE_NOT_AVAILABLE(0xfd400003) : core fw error(0x2)
06-22 14:30:41.701+0900 D/local   ( 9373): lat = 37.283655, lon = 127.044696
06-22 14:30:42.511+0900 I/Tizen::Net::Wifi( 1007): (928) > The background scan result updated.
06-22 14:30:42.621+0900 W/LOCATION( 9373): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:30:42.621+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:30:42.621+0900 W/LOCATION( 9373): location-hybrid.c: hybrid_get_current_method(90) > Current Method [2]
06-22 14:30:42.621+0900 E/EFL     ( 9373): ecore<9373> ecore_main.c:414 _ecore_main_fdh_poll_del() Failed to delete epoll fd 46! (errno=1)
06-22 14:30:42.631+0900 I/CAPI_TELEPHONY(  929): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
06-22 14:30:45.791+0900 E/EFL     ( 9373): elementary<9373> elm_map.c:1248 _mouse_up_cb() Mouse up!!!!!
06-22 14:30:46.301+0900 E/EFL     ( 9373): elementary<9373> elm_map.c:1248 _mouse_up_cb() Mouse up!!!!!
06-22 14:30:46.451+0900 D/local   ( 9373): map changed lat = 37.280336, lon = 127.044654
06-22 14:30:46.501+0900 E/EFL     ( 9373): elementary<9373> elm_map.c:1248 _mouse_up_cb() Mouse up!!!!!
06-22 14:30:49.901+0900 D/local   ( 9373): submit button pressed
06-22 14:30:50.041+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(142) > dead_pid = 9373 pgid = 9373
06-22 14:30:50.041+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(123) > dead_pid(9373)
06-22 14:30:50.041+0900 I/AUL_PAD (  471): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-22 14:30:50.041+0900 I/AUL_PAD (  471): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-22 14:30:50.041+0900 W/AUL_AMD (  447): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-22 14:30:50.041+0900 W/AUL_AMD (  447): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-22 14:30:50.091+0900 I/AUL_AMD (  447): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 9373
06-22 14:30:50.101+0900 I/Tizen::System(  993): (246) > Terminated app [org.tizen.local]
06-22 14:30:50.101+0900 I/Tizen::Io(  993): (729) > Entry not found
06-22 14:30:50.101+0900 I/Tizen::App(  978): (243) > App[org.tizen.local] pid[9373] terminate event is forwarded
06-22 14:30:50.101+0900 I/Tizen::System(  978): (256) > osp.accessorymanager.service provider is found.
06-22 14:30:50.101+0900 I/Tizen::System(  978): (196) > Accessory Owner is removed [org.tizen.local, 9373, ]
06-22 14:30:50.101+0900 I/Tizen::System(  978): (256) > osp.system.service provider is found.
06-22 14:30:50.101+0900 I/Tizen::App(  978): (506) > TerminatedApp(org.tizen.local)
06-22 14:30:50.101+0900 I/Tizen::App(  978): (512) > Not registered pid(9373)
06-22 14:30:50.101+0900 I/Tizen::App(  978): (782) > Finished invoking application event listener for org.tizen.local, 9373.
06-22 14:30:50.111+0900 I/Tizen::System(  993): (157) > change brightness system value.
06-22 14:30:50.111+0900 I/Tizen::App(  993): (782) > Finished invoking application event listener for org.tizen.local, 9373.
06-22 14:30:50.131+0900 W/PROCESSMGR(  359): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=621
06-22 14:30:50.161+0900 I/CAPI_APPFW_APPLICATION(  621): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-22 14:30:50.161+0900 E/cluster-home(  621): homescreen-main.cpp: app_resume(422) >  app resume
06-22 14:30:50.221+0900 W/CRASH_MANAGER( 9478): worker.c: worker_job(1198) > 11093736c6f63143495104
