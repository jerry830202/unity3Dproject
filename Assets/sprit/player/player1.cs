using UnityEngine;
using System.Collections;

public class player1 : MonoBehaviour {
	public GameObject obj_player1;
	public float star_x;
	public float star_y;
	public float star_z;
	// Use this for initialization
	void Start () {
		star_x=obj_player1.transform.position.x;
		star_y=obj_player1.transform.position.y;
		star_z=obj_player1.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		//上下左右
		if (cube.b_over == false) {

			if (Input.GetKey (KeyCode.A)) {
				obj_player1.transform.position += new Vector3 (-0.1f, 0, 0);
				if (Input.GetKey (KeyCode.S)) {
					obj_player1.transform.position += new Vector3 (-0.05f, 0, -0.05f);
				} else if (Input.GetKey (KeyCode.W)) {
					obj_player1.transform.position += new Vector3 (-0.05f, 0, 0.05f);
				}
			} else if (Input.GetKey (KeyCode.D)) {
				obj_player1.transform.position += new Vector3 (0.1f, 0, 0);
				if (Input.GetKey (KeyCode.S)) {
					obj_player1.transform.position += new Vector3 (0.05f, 0, -0.05f);
				} else if (Input.GetKey (KeyCode.W)) {
					obj_player1.transform.position += new Vector3 (0.05f, 0, 0.05f);
				}
			} else if (Input.GetKey (KeyCode.W)) {
				obj_player1.transform.position += new Vector3 (0, 0, 0.1f);
				if (Input.GetKey (KeyCode.A)) {
					obj_player1.transform.position += new Vector3 (-0.05f, 0, 0.05f);
				} else if (Input.GetKey (KeyCode.D)) {
					obj_player1.transform.position += new Vector3 (0.05f, 0, 0.05f);
				}
			} else if (Input.GetKey (KeyCode.S)) {
				obj_player1.transform.position += new Vector3 (0, 0, -0.1f);
				if (Input.GetKey (KeyCode.A)) {
					obj_player1.transform.position += new Vector3 (-0.05f, 0, -0.05f);
				} else if (Input.GetKey (KeyCode.D)) {
					obj_player1.transform.position += new Vector3 (0.05f, 0, -0.05f);
				}
			} 
		}
		if (restart.reset) {
			obj_player1.transform.position=new Vector3 (star_x,star_y,star_z);

		}
	}
}
