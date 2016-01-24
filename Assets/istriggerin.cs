using UnityEngine;
using System.Collections;

public class istriggerin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("triggerin");
	}
	void OnTriggerExit (Collider other)
	{
		Debug.Log("triggerout");
	}

}
