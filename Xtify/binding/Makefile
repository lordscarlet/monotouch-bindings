BTOUCH=/Developer/MonoTouch/usr/bin/btouch

all: XtifyPush.dll

xtify-ios-sdk-2.32.zip: 
	curl -O http://developer.xtify.com/download/attachments/1015820/xtify-ios-sdk-2.32.zip

xtify-framework.stamp: xtify-ios-sdk-2.32.zip
	unzip $^
	touch xtify-framework.stamp

XtifyPush.dll: Makefile xtify-framework.stamp AssemblyInfo.cs XtifyLib.cs extra.cs enums.cs
	$(BTOUCH) -unsafe XtifyLib.cs -s enums.cs -x:AssemblyInfo.cs -x extra.cs --out=$@ --link-with=xtify-ios-sdk-2.32/XtifyLib/XtifyPush.embeddedframework/XtifyPush.framework/XtifyPush,XtifyPush --outdir=tmp

clean:
	-rm -rf XtifyPush.framework tmp *.a *.dll *.stamp
