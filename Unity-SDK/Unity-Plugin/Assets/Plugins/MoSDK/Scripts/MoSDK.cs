using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class MoSDK {

	[DllImport ("__Internal")]
	private static extern void _StartWithAppId(string appId);

	[DllImport ("__Internal")]
	private static extern void _ShowNextAd();

	private static bool isInitialized = false;

	public static void Init(){
		if (MoSDKSettings.ShowDebugValue) {
			Debug.Log("MoSDK.Init call");
		}
		if (MoSDK.isInitialized == true) {
			if (MoSDKSettings.ShowDebugValue) {
				Debug.Log("MoSDK.Init already initialized");
			}
			return;
		} else{
			if (MoSDKSettings.ShowDebugValue) {
				Debug.Log("Starting with appIdValue");
				if (MoSDKSettings.AppIdValue == "0" || MoSDKSettings.AppIdValue.Trim() == ""){
					Debug.LogError("Invalid App Id");
				}
			}
			MoSDK.StartWithAppId (MoSDKSettings.AppIdValue);
		}
	}

	private static void StartWithAppId(string appId)
	{
		if (MoSDK.isInitialized == true) {
			return;
		}else{
			MoSDK.isInitialized = true;
			if (Application.platform != RuntimePlatform.OSXEditor) {
				_StartWithAppId (appId);
			}
		}
	}
	
	public static void ShowNextAd()
	{
		if (MoSDKSettings.ShowDebugValue) {
			Debug.Log("MoSDK.ShowNextAd call");
		}
		if (MoSDK.isInitialized == true) {
			if (Application.platform != RuntimePlatform.OSXEditor){
				_ShowNextAd();
			}
		}else{
			Debug.LogError("You need to init MoSDK before showing the next Ad. // MoSDK.Init();");
		}
	}
}
