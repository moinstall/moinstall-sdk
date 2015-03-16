
function Start () 
{
	//Recomended Init func calling place is Start function
	//Init MoSDK (You could call the Init function several times, But it loads only first time)
	MoSDK.Init();
}

function OnGUI () 
{	
	if (GUI.Button(new Rect(50, 100, 150, 50), "next"))
	{
		//Show ad
		MoSDK.ShowNextAd();
	}
	
	if (GUI.Button(new Rect(50, 400, 150, 50), "Scene 2"))
	{
		//Load a scene
		Application.LoadLevel("MoSDKScene2");
	}
}