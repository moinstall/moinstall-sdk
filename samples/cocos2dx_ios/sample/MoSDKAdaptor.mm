//  MoSDKWrapper.m
//  Sample
//  Created by Vasyl Zakharko on 4/4/15.
#include "MoSDKAdaptor.h"
#import <MoSDK/MoSDK.h>

void MoSDK_startWithAppId( const char* appId )
{
	[MoSDK startWithAppId:[NSString stringWithUTF8String:appId]];
}

void MoSDK_showNextAd()
{
	[MoSDK showNextAd];
}