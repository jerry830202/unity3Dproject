using UnityEngine;
using System.Collections;

public class AnimatorController : MonoBehaviour {

	public Animator animator;
	public Animation animation;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
		animation = gameObject.GetComponent<Animation> ();
	}

	// Update is called once per frame
	void Update () {

		//animator.SetFloat ("velocity", this.rigidbody.velocity.magnitude);
		if (this.rigidbody.velocity.magnitude > 0.1) {
			Debug.Log (this.rigidbody.velocity.magnitude);
			//this.transform.Rotate(new Vector3(0,90,0),Space.Self);
			//this.GetComponent<Animation>().Play("loop_walk_funny");

			animation.Play("loop_walk_funny");
		//	this.rigidbody.velocity=new Vector3(0.0f,0.0f,0.0f);
		}
	}
}