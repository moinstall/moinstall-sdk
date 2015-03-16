//
//  MoSDK.h
//  MoSDK
//
//  Created by xiaofeiwang on 1/17/15.
//  Copyright (c) 2015 com.ubc.felix. All rights reserved.
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


@end

