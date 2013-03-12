using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.CoreLocation;
using MonoTouch.UIKit;
using MonoTouch.CoreData;

namespace XtifyPush
{
	// #define xAppKey @"5751c6cd-0f79-434a-a5f0-f524deba874a"

	[BaseType (typeof (NSObject))]
	public interface XLXtifyOptions {

		[Static]
		[Export ("getXtifyOptions")]
		XLXtifyOptions Options { get;}

		[Export ("getAppKey")]
		string GetAppKey ();
		
		[Export ("isLocationRequired")]
		bool IsLocationRequired ();
		
		[Export ("isBackgroundLocationRequired")]
		bool IsBackgroundLocationRequired ();
		
		[Export ("isLogging")]
		bool IsLogging ();
		
		[Export ("isMultipleMarkets")]
		bool IsMultipleMarkets ();
		
		[Export ("getManageBadgeType")]
		XLBadgeManagedType GetManageBadgeType ();
		
		//		[Export ("xtLogMessage:content:...")]
		//		void XtLogMessagecontent... (string header, string message,, );
		//		
	}

	// @interface XLappMgr : NSObject <UIAlertViewDelegate> 
	[BaseType (typeof (UIAlertViewDelegate))]
	interface XLappMgr //: UIAlertViewDelegate 
	{
		[Export ("anAppKey")]
		string AnAppKey { get; set;  }
		
		[Export ("userTimeZone")]
		string UserTimeZone { get; set;  }
		
		[Export ("lastLocationUpdateDate")]
		NSDate LastLocationUpdateDate { get; set;  }
		
		[Export ("prodName")]
		string ProdName { get; set;  }
		
		[Export ("isInGettingMsgLoop")]
		bool IsInGettingMsgLoop { get; set;  }
		
		[Export ("timerBulkUpdate")]
		NSTimer TimerBulkUpdate { get; set;  }
		
		[Export ("lastPush")]
		NSDictionary LastPush { get; set;  }
		
		[Export ("inboxDelegate")]
		NSObject InboxDelegate { get; set;  }
		
		[Export ("didInboxChangeSelector")]
		Selector DidInboxChangeSelector { get; set;  }
		
		[Export ("developerNavigationControllerSelector")]
		Selector DeveloperNavigationControllerSelector { get; set;  }
		
		[Export ("curCountry")]
		string CurCountry { get; set;  }
		
		[Export ("curLocale")]
		string CurLocale { get; set;  }
		
		[Export ("activeTagArray")]
		NSMutableArray ActiveTagArray { get; set;  }
		
		[Export ("developerActiveTagsSelector")]
		Selector DeveloperActiveTagsSelector { get; set;  }
		
		[Export ("developerXidNotificationSelector")]
		Selector DeveloperXidNotificationSelector { get; set;  }
		
		[Export ("developerRegisterNotificationSelector")]
		Selector DeveloperRegisterNotificationSelector { get; set;  }
		
		[Static]
		[Export ("get")]
		XLappMgr Current { get; }
		
		[Export ("initilizeXoptions:")]
		void InitializeXoptions (XLXtifyOptions xOptions);
		
		[Export ("registerForPush")]
		void RegisterForPush ();
		
		[Export ("launchWithOptions:andOptions:")]
		void LaunchWithOptionsandOptions (UIApplication application, NSDictionary launchOptions);
		
		[Export ("registerWithXtify:")]
		void RegisterWithXtify (NSData devToken);
		
		[Export ("doXtifyRegistration:newAppKey")]
		void DoXtifyRegistrationnewAppKey (string newAppKey );
		
		[Export ("updateXtifyRegistration:")]
		void UpdateXtifyRegistration (string newAppKey);
		
		[Export ("updateAppKey:")]
		void UpdateAppKey (string appKey);
		
		[Export ("appEnterBackground")]
		void AppEnterBackground ();
		
		[Export ("appEnterActive")]
		void AppEnterActive ();
		
		[Export ("appEnterForeground")]
		void AppEnterForeground ();
		
		[Export ("appReceiveNotification:")]
		void AppReceiveNotification (NSDictionary userInfo);
		
		[Export ("displayGenericAlert:messageContent")]
		void DisplayGenericAlertmessageContent (string messageContent );
		
		[Export ("updateLocDate:")]
		void UpdateLocDate (NSDate updateDate);
		
		[Export ("finishHandleNotification")]
		void FinishHandleNotification ();
		
		[Export ("applicationWillTerminate")]
		void ApplicationWillTerminate ();
		
		[Export ("updateStats:withTS:")]
		void UpdateStatswithTS (string type, string ts);
		
		[Export ("sendActionsToServerBulk:")]
		void SendActionsToServerBulk (NSTimer timer);
		
		[Export ("getLocationRequiredFlag")]
		bool GetLocationRequiredFlag ();
		
		[Export ("getBackgroundLocationRequiredFlag")]
		bool GetBackgroundLocationRequiredFlag ();
		
		[Export ("isLocationSettingOff")]
		bool IsLocationSettingOff ();
		
		[Export ("updateLocationRequiredFlag:")]
		void UpdateLocationRequiredFlag (bool value);
		
		[Export ("updateBackgroundLocationFlag:")]
		void UpdateBackgroundLocationFlag (bool value);
		
		[Export ("getLastLnownLocation")]
		CLLocationCoordinate2D GetLastLnownLocation ();
		
		[Export ("updateLocation")]
		void UpdateLocation ();
		
//		[Export ("updateLocationWithCoordinate:latLonandAlt:andAccuracy:")]
//		void UpdateLocationWithCoordinatelatLonandAltandAccuracy (CLLocationCoordinate2D latLongandAlt, float altitude, float accuracy);
		
		[Export ("appDisplayNotificationNoAlert:")]
		void AppDisplayNotificationNoAlert (NSDictionary pushMessage);
		
		[Export ("appDisplayNotification:withAlert:alertFlag")]
		void AppDisplayNotificationwithAlertalertFlag (NSDictionary pushMessage, bool alertFlag );
		
		[Export ("getPenddingNotifications")]
		void GetPenddingNotifications ();
		
		[Export ("getInboxViewController")]
		UIViewController GetInboxViewController ();
		
		[Export ("getSpringBoardBadgeCount")]
		int GetSpringBoardBadgeCount ();
		
//		[Export ("		setSpringBoardBadgeCount:count")]
//		void 		setSpringBoardBadgeCountcount (int , );
		
		[Export ("getServerBadgeCount")]
		int GetServerBadgeCount ();
		
		[Export ("setServerBadgeCount:count")]
		void 		setServerBadgeCountcount (int count );
		
//		[Export ("		setBadgeCountSpringBoardAndServer:count")]
//		void 		setBadgeCountSpringBoardAndServercount (int , );
		
//		[Export ("updateBadgeCount:valueandOperator:op")]
//		void UpdateBadgeCountvalueandOperatorop (int , char , );
		
		[Export ("getInboxUnreadMessageCount")]
		int GetInboxUnreadMessageCount ();
		
//		[Export ("inboxChangedInternal:count")]
//		void InboxChangedInternalcount (int , );
		
		[Export ("messageCountChanged")]
		void MessageCountChanged ();
		
		[Export ("getDeveloperNavigationController")]
		UINavigationController GetDeveloperNavigationController ();
		
		[Export ("moveTabbarToInboxNavController")]
		void MoveTabbarToInboxNavController ();
		
		[Export ("performDeveloperCustomAction:")]
		void PerformDeveloperCustomAction (string actionData);
		
		[Export ("getBadgeMethod")]
		XLBadgeManagedType GetBadgeMethod ();
		
		[Export ("updateBadgeFlag:")]
		void UpdateBadgeFlag (bool value);
		
		[Export ("setSnid:")]
		void SetSnid (string value);
		
		[Export ("getSnid")]
		string GetSnid ();
		
		[Export ("addTag:")]
		void AddTag (NSMutableArray tags);
		
		[Export ("getTagString:tags")]
		string GetTagStringtags (NSMutableArray tags );
		
		[Export ("doTagRequest:tagUrlString")]
		void DoTagRequesttagUrlString (string tagUrlString );
		
		[Export ("unTag:")]
		void UnTag (NSMutableArray tags);
		
		[Export ("setTag:")]
		void SetTag (NSMutableArray tags);
		
		[Export ("getActiveTags")]
		void GetActiveTags ();
		
//		[Export ("successActiveTagMethod:request")]
//		void SuccessActiveTagMethodrequest (xASIHTTPRequest request );
		
		[Export ("doActiveTagsRequest:tagString")]
		void DoActiveTagsRequesttagString (string tagString );
		
		[Export ("didReceiveTagRequest:")]
		void DidReceiveTagRequest (NSMutableArray anArray);
		
		[Export ("getXid")]
		string GetXid ();
		
		[Export ("checkPushEnabled")]
		void CheckPushEnabled ();
		
		[Export ("getPushSettingValue")]
		string GetPushSettingValue ();
		
//		[Export ("changeDbPushFlag:flag")]
//		void ChangeDbPushFlagflag (string , );
//		
//		[Export ("insertSimpleAck:simpleId")]
//		void InsertSimpleAcksimpleId (string , );
//		
//		[Export ("insertSimpleDisp:simpleId")]
//		void InsertSimpleDispsimpleId (string , );
//		
//		[Export ("insertSimpleClear:simpleId")]
//		void InsertSimpleClearsimpleId (string , );
//		
//		[Export ("insertSimpleClick:simpleId")]
//		void InsertSimpleClicksimpleId (string , );
//		
//		[Export ("insertRichDisplay:richId")]
//		void InsertRichDisplayrichId (string , );
//		
//		[Export ("insertRicShare:richId")]
//		void InsertRicSharerichId (string , );
//		
//		[Export ("insertRichAction:richId")]
//		void InsertRichActionrichId (string , );
//		
//		[Export ("insertRichMap:richId")]
//		void InsertRichMaprichId (string , );
//		
//		[Export ("insertRichDelete:richId")]
//		void InsertRichDeleterichId (string , );
		
		[Export ("insertInboxClick")]
		void InsertInboxClick ();
		
		[Export ("sendTimeZoneToServer:")]
		void SendTimeZoneToServer (string currentTz);
		
		[Export ("hasTZChanged")]
		void HasTZChanged ();
		
		[Export ("getSdkVer")]
		string GetSdkVer ();
		
		[Export ("recreateTagDb")]
		void RecreateTagDb ();
		
		[Export ("getPushEnabled")]
		string GetPushEnabled ();
		
		[Export ("isMultipleMarkets")]
		bool IsMultipleMarkets ();
		
		[Export ("addLocale:")]
		void AddLocale (string locale);
		
		[Export ("untagLocale:")]
		void UntagLocale (string locale);
		
		[Export ("getAppDetails")]
		NSMutableDictionary GetAppDetails ();
		
		[Export ("saveRegTimestamp")]
		void SaveRegTimestamp ();
		
		[Export ("getRegTimestamp")]
		string GetRegTimestamp ();
		
		[Export ("removeAllNotifications")]
		void RemoveAllNotifications ();
		
		[Export ("xidChanged")]
		void XidChanged ();
		
		[Export ("registerComplete")]
		void RegisterComplete ();
		
		[Export ("getLastNetworkStatus")]
		bool GetLastNetworkStatus ();
		
	}

	
	[BaseType (typeof (NSObject))]
	interface XLCustomInboxMgr {
		[Export ("setCiMessagSelectors:failSelector:andDelegate:")]
		void SetCiMessagSelectorsfailSelectorandDelegate (Selector aSuccessSelector, Selector aFailureSelector, NSObject aDelegate);
		
		[Export ("setCiPendingSelectors:failSelector:andDelegate:")]
		void SetCiPendingSelectorsfailSelectorandDelegate (Selector aSuccessSelector, Selector aFailureSelector, NSObject aDelegate);
		
		[Export ("getCIMessage:")]
		void GetCIMessage (string mid);
		
		[Export ("getCIPenddingNotifications")]
		void GetCIPenddingNotifications ();
		
	}

	
	[BaseType (typeof (NSManagedObject))]
	interface RichDbMessage {
		[Export ("subject")]
		string Subject { get; set;  }
		
		[Export ("mid")]
		string Mid { get; set;  }
		
		[Export ("actionLabel")]
		string ActionLabel { get; set;  }
		
		[Export ("userLon")]
		NSNumber UserLon { get; set;  }
		
		[Export ("ruleLon")]
		NSNumber RuleLon { get; set;  }
		
		[Export ("read")]
		NSNumber Read { get; set;  }
		
		[Export ("actionData")]
		string ActionData { get; set;  }
		
		[Export ("actionType")]
		string ActionType { get; set;  }
		
		[Export ("userLat")]
		NSNumber UserLat { get; set;  }
		
		[Export ("aDate")]
		NSDate ADate { get; set;  }
		
		[Export ("ruleLat")]
		NSNumber RuleLat { get; set;  }
		
		[Export ("content")]
		string Content { get; set;  }
		
		[Export ("expirationDate")]
		NSDate ExpirationDate { get; set;  }
		
		[Export ("setFromJson:")]
		void SetFromJson (XLRichJsonMessage xMessage);
		
		[Export ("updateMessage:")]
		void UpdateMessage (bool value);
		
	}

	
	[BaseType (typeof (NSObject))]
	interface XLhmSupport {
		[Export ("userCountryCode")]
		string UserCountryCode { get; set;  }
		
		[Export ("appKeyMapping")]
		NSMutableDictionary AppKeyMapping { get; set;  }
		
		[Export ("localeCountryMapping")]
		NSMutableDictionary LocaleCountryMapping { get; set;  }
		
		[Export ("countryInitialMapping")]
		NSMutableDictionary CountryInitialMapping { get; set;  }
		
		[Export ("localeLanguageMapping")]
		NSMutableDictionary LocaleLanguageMapping { get; set;  }
		
		[Export ("changeCountryCode:")]
		void ChangeCountryCode (string newCountryCode);
		
		[Export ("getAppkey")]
		string GetAppkey ();
		
		[Export ("setCountryLocaleDict")]
		void SetCountryLocaleDict ();
		
	}

	
	[BaseType (typeof (NSObject))]
	interface XLRichJsonMessage {
//		[Export ("ver,*mid,")]
//		string Ver,*mid, { get; set;  }
		
		[Export ("userLat")]
		string UserLat { get; set;  }
		
	}


	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
	//
}

