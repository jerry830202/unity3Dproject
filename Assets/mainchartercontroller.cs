using UnityEngine;
using System.Collections;

public class mainchartercontroller : MonoBehaviour {

	public GameObject player=null;
	public float movespeed = 5.0f;
	public float rotatoinspeed = 1f;
	public Camera m_camera = null;
	public float distance = 3.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 rightvec = m_camera.transform.right;
		rightvec.y = 0.0f;

		Vector3 forwardvec = m_camera.transform.forward;
		forwardvec.y = 0.0f;

		if (Input.GetKey (KeyCode.A) == true) {
			player.transform.Translate (-1 * rightvec * Time.deltaTime * movespeed, Space.World);
			player.transform.rotation = Quaternion.LookRotation (-1 * rightvec);
			m_camera.transform.Translate(-1*rightvec * Time.deltaTime*movespeed , Space.World);
			m_camera.transform.rotation = Quaternion.LookRotation(-1*rightvec);

		} else if (Input.GetKey (KeyCode.D) == true) {
			player.transform.Translate (1 * rightvec * Time.deltaTime * movespeed, Space.World);
			player.transform.rotation = Quaternion.LookRotation (1 * rightvec);
			m_camera.transform.Translate (1 * rightvec * Time.deltaTime * movespeed, Space.World);
			m_camera.transform.rotation = Quaternion.LookRotation (1 * rightvec);
		} else if (Input.GetKey (KeyCode.W) == true) {
			player.transform.Translate (1 * forwardvec * Time.deltaTime * movespeed, Space.World);
			player.transform.rotation = Quaternion.LookRotation (1 * forwardvec);
			m_camera.transform.Translate (1 * forwardvec * Time.deltaTime * movespeed, Space.World);
			m_camera.transform.rotation = Quaternion.LookRotation (1 * forwardvec);
		} else if (Input.GetKey (KeyCode.S) == true) {
			player.transform.Translate(-1*forwardvec*Time.deltaTime*movespeed , Space.World);
			player.transform.rotation=Quaternion.LookRotation(-1*forwardvec);
			m_camera.transform.Translate(-1*forwardvec*Time.deltaTime*movespeed , Space.World);
			m_camera
				.transform.rotation=Quaternion.LookRotation(-1*forwardvec);
		}

	}
}
