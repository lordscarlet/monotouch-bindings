using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.CoreLocation;
using MonoTouch.UIKit;
using MonoTouch.CoreData;

namespace XtifyPush
{
	[BaseType (typeof (NSObject))]
	public interface XLXtifyOptions {

		[Static]
		[Export ("xtifyOptions")]
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

}

