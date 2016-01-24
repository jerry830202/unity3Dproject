using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {
	public GameObject obj_cube;
	public float f_time=0f;
	public float f_timetotime;
	//public float f_endtime=60;
	public static bool b_over=true;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (b_over == false) {
			f_time += Time.deltaTime;//累計
			f_timetotime=Random.value%1+1;
			Vector3 v3_random = new Vector3 (Random.Range (0.5f, 20), Random.Range (1, 5), Random.Range (0.5f, 20));
		
			if (f_time > f_timetotime) {
				f_time = 0;
				GameObject obj_cube_clone = Instantiate (obj_cube, v3_random, Quaternion.identity)as GameObject;
			}


			if ((Time.time-rule.resettime) > 60) {//60sec to end
				b_over = true;
			}
		}
	}

}
