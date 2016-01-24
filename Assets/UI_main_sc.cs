using UnityEngine;
using System.Collections;

public class UI_main_sc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UIEventListener.Get (GameObject.Find ("Start")).onClick = onClick;
		UIEventListener.Get (GameObject.Find ("Leave")).onClick = onClick;

	}


	void onClick(GameObject go){
	
		if (go.name == "Leave")
			Application.Quit();
		else {
			Instantiate( Resources.Load("UI_loading") as GameObject);
			Destroy(GameObject.Find ("UI_main(Clone)"));
			Destroy(GameObject.Find ("Scene_main(Clone)"));
		}
	}
}
