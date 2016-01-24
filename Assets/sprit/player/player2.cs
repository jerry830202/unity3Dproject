using UnityEngine;
using System.Collections;

public class player2 : MonoBehaviour {
	public GameObject obj_player2;
	public float star2_x;
	public float star2_y;
	public float star2_z;
	// Use this for initialization
	void Start () {
		star2_x=obj_player2.transform.position.x;
		star2_y=obj_player2.transform.position.y;
		star2_z=obj_player2.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		//上下左右
		if (cube.b_over == false) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				obj_player2.transform.position += new Vector3 (-0.1f, 0, 0);
				if (Input.GetKey (KeyCode.DownArrow)) {
					obj_player2.transform.position += new Vector3 (-0.05f, 0, -0.05f);
				} else if (Input.GetKey (KeyCode.UpArrow)) {
					obj_player2.transform.position += new Vector3 (-0.05f, 0, 0.05f);
				}
			} else if (Input.GetKey (KeyCode.RightArrow)) {
				obj_player2.transform.position += new Vector3 (0.1f, 0, 0);
				if (Input.GetKey (KeyCode.DownArrow)) {
					obj_player2.transform.position += new Vector3 (0.05f, 0, -0.05f);
				} else if (Input.GetKey (KeyCode.UpArrow)) {
					obj_player2.transform.position += new Vector3 (0.05f, 0, 0.05f);
				}
			} else if (Input.GetKey (KeyCode.UpArrow)) {
				obj_player2.transform.position += new Vector3 (0, 0, 0.1f);
				if (Input.GetKey (KeyCode.LeftArrow)) {
					obj_player2.transform.position += new Vector3 (-0.05f, 0, 0.05f);
				} else if (Input.GetKey (KeyCode.RightArrow)) {
					obj_player2.transform.position += new Vector3 (0.05f, 0, 0.05f);
				}
			} else if (Input.GetKey (KeyCode.DownArrow)) {
				obj_player2.transform.position += new Vector3 (0, 0, -0.1f);
				if (Input.GetKey (KeyCode.LeftArrow)) {
					obj_player2.transform.position += new Vector3 (-0.05f, 0, -0.05f);
				} else if (Input.GetKey (KeyCode.RightArrow)) {
					obj_player2.transform.position += new Vector3 (0.05f, 0, -0.05f);
				}
			} 
		}
		if (restart.reset) {
			obj_player2.transform.position=new Vector3 (star2_x,star2_y,star2_z);
			
		}
	}
}
