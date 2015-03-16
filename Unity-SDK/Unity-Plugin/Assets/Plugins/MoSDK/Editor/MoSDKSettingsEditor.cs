#if UNITY_EDITOR 

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

[CustomEditor(typeof(MoSDKSettings))]
public class MoSDKSettingsEditor : Editor
{
	GUIContent appIdLabel = new GUIContent("App Id [?]:", "MoSDK App Ids can be found at foo.com");
	
	private MoSDKSettings instance;
	
	public override void OnInspectorGUI()
	{
		instance = (MoSDKSettings)target;
		
		AppIdGUI();
	}
	
	private void AppIdGUI()
	{
		EditorGUILayout.HelpBox("1) Add the MoSDK App Id associated with this game", MessageType.None);
		if (instance.AppId == "0" || instance.AppId.Trim() == "")
		{
			EditorGUILayout.HelpBox("Invalid App Id", MessageType.Error);
		}
		EditorGUILayout.BeginHorizontal();
		EditorGUILayout.LabelField(appIdLabel);
		EditorGUILayout.EndHorizontal();

		EditorGUILayout.BeginHorizontal();
		instance.SetAppId(EditorGUILayout.TextField(instance.AppId));
		EditorGUILayout.EndHorizontal();

		EditorGUILayout.Space();
		EditorGUILayout.Space();
		EditorGUILayout.Space();

		EditorGUILayout.BeginHorizontal();
		GUIContent showDebugLabel = new GUIContent("Show Debug [?]", "Shows MoSDK function's debug logs");
		instance.SetShowDebug (EditorGUILayout.Toggle(showDebugLabel, MoSDKSettings.ShowDebugValue));
		EditorGUILayout.EndHorizontal();

		EditorGUILayout.Space();
	}
	

	
	private void SelectableLabelField(GUIContent label, string value)
	{
		EditorGUILayout.BeginHorizontal();
		EditorGUILayout.LabelField(label, GUILayout.Width(180), GUILayout.Height(16));
		EditorGUILayout.SelectableLabel(value, GUILayout.Height(16));
		EditorGUILayout.EndHorizontal();
	}
}
#endif