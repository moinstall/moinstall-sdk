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

//forward declarations
@class MoSDK;

// MosSDK delegate protocol
@protocol MoSDKDelegate <NSObject>
@optional
// Methods for notification of Ads related events.
// Notifies about MoSDK received request to show Ad
-(void)MoSDK_didRequestedAd:(MoSDK*)moSDK;
// Notifies about MoSDK has displayed Ad
-(void)MoSDK_didShowAd:(MoSDK*)moSDK;
// Notifies about MoSDK received user's click on Ad
-(void)MoSDK_didClickAd:(MoSDK*)moSDK;
@end

// MoSDK interface
@interface MoSDK : NSObject

@property(nonatomic, weak) id< MoSDKDelegate > delegate;

// Returns/creates singleton shared instance of MoSDK
+ (MoSDK *)sharedInstance;
// Returns MoSDK version string
+ (NSString*)versionInfo;
// Initializes MoSDK with specified credentials
+ (void)startWithAppId:(NSString *)appId;
// Requests Ad displaying
+ (void)showNextAd;

@end

