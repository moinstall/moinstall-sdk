using UnityEngine;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;

[InitializeOnLoad]
#endif
public class MoSDKSettings : ScriptableObject
{
	
	const string moSDKSettingsAssetName = "MoSDKSettings";
	const string moSDKSettingsPath = "Plugins/MoSDK/Resources";
	const string moSDKSettingsAssetExtension = ".asset";
	
	private static MoSDKSettings instance;
	
	static MoSDKSettings Instance
	{
		get
		{
			if (instance == null)
			{
				instance = Resources.Load(moSDKSettingsAssetName) as MoSDKSettings;
				if (instance == null)
				{
					// If not found, autocreate the asset object.
					instance = CreateInstance<MoSDKSettings>();
					#if UNITY_EDITOR
					string properPath = Path.Combine(Application.dataPath, moSDKSettingsPath);
					if (!Directory.Exists(properPath))
					{
						AssetDatabase.CreateFolder("Assets/Plugins/MoSDK", "Resources");
					}
					
					string fullPath = Path.Combine(Path.Combine("Assets", moSDKSettingsPath),
					                               moSDKSettingsAssetName + moSDKSettingsAssetExtension
					                               );
					AssetDatabase.CreateAsset(instance, fullPath);
					#endif
				}
			}
			return instance;
		}
	}
	
	#if UNITY_EDITOR
	[MenuItem("MoSDK/Edit Settings")]
	public static void Edit()
	{
		Selection.activeObject = Instance;
	}
	
	[MenuItem("MoSDK/open google.com")]
	public static void OpenDocumentation()
	{
		string url = "https://www.google.com/?q=MoSDK+document";
		Application.OpenURL(url);
	}
	#endif
	
	#region App Settings

	[SerializeField]
	private string appId = "0";
	private bool showDebug = true;

	public void SetAppId(string value)
	{
		if (appId != value)
		{
			appId = value;
			DirtyEditor();
		}
	}

	public void SetShowDebug(bool value)
	{
		if (showDebug != value)
		{
			showDebug = value;
			DirtyEditor();
		}
	}

	public static string AppIdValue
	{
		get { return Instance.appId; }
	}

	public static bool ShowDebugValue
	{
		get { return Instance.showDebug; }
	}
	
	public string AppId
	{
		get { return appId; }
		set
		{
			if (appId != value)
			{
				appId = value;
				DirtyEditor();
			}
		}
	}

	public bool ShowDebug
	{
		get { return showDebug; }
		set
		{
			if (showDebug != value)
			{
				showDebug = value;
				DirtyEditor();
			}
		}
	}

	
	private static void DirtyEditor()
	{
		#if UNITY_EDITOR
		EditorUtility.SetDirty(Instance);
		#endif
	}
	
	#endregion
}

