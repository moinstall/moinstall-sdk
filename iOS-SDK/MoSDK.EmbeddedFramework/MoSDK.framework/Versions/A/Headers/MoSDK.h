//
//  MoSDK.h
//  MoSDK
//
//  Created by William Guan on 12/19/2014.
//  Copyright (c) 2014,2015 Mogames Inc. All rights reserved.
//

#import <Foundation/Foundation.h>

//! Project version number for AdsPackage.
FOUNDATION_EXPORT double AdsPackageVersionNumber;

//! Project version string for AdsPackage.
FOUNDATION_EXPORT const unsigned char AdsPackageVersionString[];

// In this header, you should import all the public headers of your framework using statements like #import <AdsPackage/AdsPackage.h>

@protocol AdsPackageDelegate <NSObject>

@optional

- (void)passLog:(NSString*)paramLog;

@end

@interface MoSDK : NSObject


+ (MoSDK *)sharedInstance;

+ (void) startWithAppId:(NSString *)appId;

+ (void) showNextAd;

+ (NSString*)versionInfo;

@end

