using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace XtifyPush {

	public class XLXtifyOptions : NSObject {
	    static XLXtifyOptions options;
	    [Export ("getXtifyOptions")] //not sure that one will be ever called by obj-C code
	    public static XLXtifyOptions XtifyOptions () {
	        return options ?? (options = new XLXtifyOptions () {
	            appKey = "yourappkey",
	            locationRequired = false,
	            manageBadge = XLBadgeManagedType.XLInboxManagedMethod
	        });
	    }    

	    string appKey;
	    bool locationRequired;
	    bool backgroundLocationRequired;
	    bool logging;
	    bool multipleMarkets;
	    XLBadgeManagedType manageBadge;

	    [Export ("getAppKey")]
	    public string GetAppKey () {
	        return appKey;
	    }

	    [Export ("isLocationRequired")]
	    public bool IsLocationRequired() {
	    	return locationRequired;
	    }

	    [Export ("isBackgroundLocationRequired")]
	    public bool IsBackgroundLocationRequired() {
	    	return backgroundLocationRequired;
	    }

	    [Export ("isLogging")]
	    public bool IsLogging() {
	    	return logging;
	    }

	    [Export ("isMultipleMarkets")]
	    public bool IsMultipleMarkets() {
	    	return multipleMarkets;
	    }

	    //same for all the getters
	    [Export ("getManageBadgeType")]
	    XLBadgeManagedType GetManageBadgeType () {
	        return manageBadge;
	    }
	    //Have to check if this is the right way to bind method with variable lengths argument, but that's the idea
	    [Export ("xtLogMessage:content:")]
	    public void LogMessage (string header, params string[] message)
	    {
	        //print the message
	    }
	}
}