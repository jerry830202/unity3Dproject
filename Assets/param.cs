using UnityEngine;
using System.Collections;

public class param : MonoBehaviour {



	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
		Instantiate( Resources.Load("UI_main") as GameObject);
		Instantiate( Resources.Load("Scene_main") as GameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
