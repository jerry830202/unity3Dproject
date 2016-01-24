using UnityEngine;
using System.Collections;

public class UI_game_sc : MonoBehaviour {


	GameObject point ;
	GameObject playerinfo;
	GameObject win;
	GameObject lose;
	public float speed ;
	public int playerhp;
	private UILabel attacknumber;
	private UILabel hpnumber;
	private UILabel pointtext;
	public int pointnumber=0;


	// Use this for initialization
	void Start () {
		playerhp = 30;
		GameObject.Find ("Peple_control").GetComponent<ThirdPersonController> ().moveSpeed += 2;
		speed = GameObject.Find ("Peple_control").GetComponent<ThirdPersonController> ().moveSpeed;
		UIEventListener.Get (GameObject.Find ("Setting")).onClick = onClick;
		UIEventListener.Get (GameObject.Find ("attack_plus")).onClick = onClick;
		UIEventListener.Get (GameObject.Find ("attack_minus")).onClick = onClick;
		UIEventListener.Get (GameObject.Find ("hp_plus")).onClick = onClick;
		UIEventListener.Get (GameObject.Find ("hp_minus")).onClick = onClick;
		UIEventListener.Get (GameObject.Find ("exit")).onClick = onClick;
		UIEventListener.Get (GameObject.Find ("winexit")).onClick = onClick;
		UIEventListener.Get (GameObject.Find ("loseexit")).onClick = onClick;
		pointtext = GameObject.Find ("pointcount").GetComponent < UILabel > ();
		attacknumber = GameObject.Find ("playerattack").GetComponent<UILabel>();
		hpnumber = GameObject.Find ("hpnum").GetComponent<UILabel> ();
		point = GameObject.Find ("point");
		point.SetActive (false);
		win = GameObject.Find ("win");
		win.SetActive (false);
		lose=GameObject.Find("lose");
		lose.SetActive (false);
		attacknumber.text = speed.ToString ();
		Debug.Log (attacknumber.text);
		hpnumber.text = playerhp.ToString ();
		Debug.Log (hpnumber.text);
		pointtext.text = pointnumber.ToString ();
	}
	void Update()
	{
		pointtext.text = pointnumber.ToString ();
		if (GameObject.Find ("robo_rigg_2014:ro_bot").GetComponent<colliderhit> ().target == 5) {
			win.SetActive(true);
		}
		if (GameObject.Find ("Front").GetComponent<Transform> ().localScale.x <= 0) {
			lose.SetActive(true);
		}
	}
	
	
	void onClick(GameObject go){
		if (go.name == "Setting") {
			if (!point.activeSelf){
				point.SetActive (true);
			}
			else{
				point.SetActive (false);
			}
		}
		if (go.name == "attack_plus") {
			Debug.Log("attackplus");
			if(pointnumber > 0){
				speed++;
				attacknumber.text=speed.ToString();
				GameObject.Find("Peple_control").GetComponent<ThirdPersonController>().moveSpeed =  speed ;
				pointnumber--;
				pointtext.text = pointnumber.ToString();
			}

		}
		if (go.name == "attack_minus") {
			Debug.Log("attackminus");
			if(speed > 1){
				speed--;
				attacknumber.text=speed.ToString();
				GameObject.Find("Peple_control").GetComponent<ThirdPersonController>().moveSpeed=speed ;
				pointnumber++;
				pointtext.text = pointnumber.ToString();
			}
		}
		if (go.name == "hp_plus") {
			Debug.Log("hp_plus");
			if(pointnumber>0){
				playerhp+=5;
				Debug.Log(playerhp);
				hpnumber.text=playerhp.ToString();
				pointnumber--;
				pointtext.text = pointnumber.ToString();
			}
		}
		if (go.name == "hp_minus") {
			Debug.Log ("hpminus");
			if (playerhp > 5) {
				playerhp -= 5;
				Debug.Log (playerhp);
				hpnumber.text = playerhp.ToString ();
				pointnumber++;
				pointtext.text = pointnumber.ToString();
			}
		}
		if (go.name == "exit") {
			Application.Quit();
			Debug.Log("get");
		}
		if (go.name == "winexit") {
			Application.Quit();

		}
		if (go.name == "loseexit") {

			Application.Quit();
		}
	}
}
