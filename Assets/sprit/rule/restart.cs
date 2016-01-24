using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {
	public static bool reset=false;
	public static bool pause=true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void OnGUI(){
		if (GUILayout.Button ("Restart")) {
			pause=false;
			rule.score=0;
			cube.b_over = false;
			rule.resettime=Time.time;
			reset=true;
		}
		if (GUI.Button(new Rect(962,0,50,20),"Pause")) {
			rule.pausetime=Time.time-rule.resettime;
			rule.resettime+=Time.deltaTime;
			cube.b_over = true;
			pause=true;
		}
		if(GUI.Button(new Rect(912,0,50,20),"Start")){
			if(pause){
			rule.resettime=Time.time-rule.pausetime;
			pause=false;
			cube.b_over = false;
			}

		}
	}
}
