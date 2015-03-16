#import <MoSDK/MoSDK.h>

NSString* CreateNSString (const char* string)
{
    if (string)
        return [NSString stringWithUTF8String: string];
    else
        return [NSString stringWithUTF8String: ""];
}

extern "C" {
    
    void _StartWithAppId(const char* appId)
    {
        [MoSDK startWithAppId:CreateNSString(appId)];
    }
    
    void _ShowNextAd()
    {
        [MoSDK showNextAd];
    }
}

