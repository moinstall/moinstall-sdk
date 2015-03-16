using UnityEngine;
using System.Collections;

public class MoSDKScene2 : MonoBehaviour {
	void Start () {
		//Recomended Init func calling place is Start function
		//Init MoSDK (You could call the Init function several times, But it loads only first time)
		MoSDK.Init ();
	}

	void OnGUI () {
		if (GUI.Button(new Rect(200, 100, 150, 50), "nextAd"))
		{
			//Show ad
			MoSDK.ShowNextAd();
		}


		if (GUI.Button(new Rect(200, 400, 150, 50), "scene1"))
		{
			//Load a scene
			Application.LoadLevel("MoSDKScene1");
		}
	}
}
