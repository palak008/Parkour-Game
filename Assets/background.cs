using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnGUI()
	{
		GUI.contentColor = Color.yellow;
		if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 150, 100, 40), "PLAY"))
		{
			Application.LoadLevel(1);
		}
		if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 200, 100, 40), "QUIT"))
		{
			Application.Quit();
		}
	}
}
                                                                                                                                                                                                                 