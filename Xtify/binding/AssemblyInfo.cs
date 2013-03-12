using System;
using MonoTouch.ObjCRuntime;
[assembly: LinkWith ("XtifyPush", LinkTarget.ArmV6, LinkerFlags = "-ObjC -all_load -fobjc-arc -lz",Frameworks = "Foundation UIKit CoreGraphics SystemConfiguration MapKit CoreData MessageUI CoreLocation CFNetwork MobileCoreServices CoreTelephony", WeakFrameworks="AdSupport Social Accounts", ForceLoad = true)]