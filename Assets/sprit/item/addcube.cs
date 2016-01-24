using UnityEngine;
using System.Collections;

public class addcube : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -5) {
			rule.score+=1;
			Destroy(gameObject);
		}
		if (restart.reset) {
			Destroy (gameObject);
		}
	}

}
