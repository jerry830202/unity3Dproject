using UnityEngine;
using System.Collections;

public class rule : MonoBehaviour {

	public static int score;
	public GUIText gui_score;
	public GUIText gui_time;
	// Use this for initialization
	public GameObject obj_gameover;
	public static float resettime=0;
	public static float pausetime=0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gui_score.text = "Score :" + score;
		if (restart.pause == false) {
			if (Time.time - resettime <= 60) {
				gui_time.text = "Time :" + (Time.time - resettime);
				obj_gameover.SetActive (false);
			} else {
				obj_gameover.SetActive (true);
			}
		}
		if(Time.time-rule.resettime>0.01){
			restart.reset=false;
		}



	}
}
