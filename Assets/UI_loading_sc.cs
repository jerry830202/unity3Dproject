using UnityEngine;
using System.Collections;

public class UI_loading_sc : MonoBehaviour {


	private UIScrollBar load;
	private UILabel label;
	private int x = 0;
	// Use this for initialization
	void Start () {
		load = GameObject.Find("Load").GetComponent<UIScrollBar>();
		label = GameObject.Find ("percent").GetComponent<UILabel> ();
		StartCoroutine (play());
	}
	
	IEnumerator play(){
		x++;
		load.barSize = load.barSize + 0.01f;
		label.text = x.ToString () + "%";
		yield return new WaitForSeconds(0.02f);
		if (load.barSize == 1f) {
			Application.LoadLevel ("Game");
			Destroy(this.gameObject);
		}else
			StartCoroutine (play());
	}
}
