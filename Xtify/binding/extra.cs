using System;

namespace XtifyPush {

public class XLXtifyOptions : NSObject {
    static XLXtifyOptions options;
    [Export ("getXtifyOptions")] //not sure that one will be ever called by obj-C code
    public static XLXtifyOptions XtifyOptions () {
        return options ?? (options = new XLXtifyOptions () {
            appKey = "yourappkey",
        });
    }

    string appKey;

    [Export ("getAppKey")]
    public string GetAppKey () {
        return appKey;
    }

    //same for all the getters

    [Export ("getManageBadgeType")
    public XLBadgeManageType GetManageBadgeType () {
        return manageBadge;
    }

    //Have to check if this is the right way to bind method with variable lengths argument, but that's the idea
    [Export ("xtLogMessage:content:")]
    public void LogMessage (string header, params string[] message)
    {
        //print the message
    }
}
