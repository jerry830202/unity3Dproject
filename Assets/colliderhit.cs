using UnityEngine;
using System.Collections;

public class colliderhit : MonoBehaviour {

	public GameObject playerinfo ;
	public int target;

	// Use this for initialization
	void Start () {
		playerinfo = GameObject.Find ("UI game");
		target=0;

	}
	
	// Update is called once per frame
	void Update () {


	}
	void OnTriggerEnter (Collider temp)
	{
		if (temp.name == "GOBLIN") {
			playerinfo.GetComponent<UI_game_sc>().playerhp --;
			Vector3 reduce;
			reduce=GameObject.Find("Front").GetComponent<Transform>().localScale;
			reduce = reduce -(new Vector3(1,0,0)*(155/playerinfo.GetComponent<UI_game_sc>().playerhp));
			Debug.Log(reduce.x);
			GameObject.Find("Front").GetComponent<Transform>().localScale=reduce;


		}
		if (temp.name == "Treasure_Chest_Prefab") {
			Debug.Log("get");

		}


	}

	void OnTriggerStay(Collider temp)
	{

		if (temp.name == "Treasure_Chest_Prefab1") {
			Debug.Log ("stay");
			Debug.Log(temp.name);
			if (Input.GetKey (KeyCode.F)) {
				target++;
				GameObject.Find ("UI game").GetComponent<UI_game_sc>().pointnumber++;

				Destroy(temp.gameObject);


			}
		}
		else if (temp.name == "Treasure_Chest_Prefab2") {
			Debug.Log ("stay");
			Debug.Log(temp.name);
			if (Input.GetKey (KeyCode.F)) {
				target++;
				GameObject.Find ("UI game").GetComponent<UI_game_sc> ().pointnumber++;
				Debug.Log(GameObject.Find ("UI game").GetComponent<UI_game_sc>().pointnumber);
				Destroy(GameObject.Find ("Treasure_Chest_Prefab2"));



			}
		}
		else if (temp.name == "Treasure_Chest_Prefab3") {
			Debug.Log ("stay");
			Debug.Log(temp.name);
			if (Input.GetKey (KeyCode.F)) {
				target++;
				GameObject.Find ("UI game").GetComponent<UI_game_sc>().pointnumber++;
				Debug.Log(GameObject.Find ("UI game").GetComponent<UI_game_sc>().pointnumber);
				Destroy(GameObject.Find ("Treasure_Chest_Prefab3"));

			
			}
		}
		else if (temp.name == "Treasure_Chest_Prefab4") {
			Debug.Log ("stay");
			Debug.Log(temp.name);
			if (Input.GetKey (KeyCode.F)) {
				target++;
				GameObject.Find ("UI game").GetComponent<UI_game_sc>().pointnumber++;
				Debug.Log(GameObject.Find ("UI game").GetComponent<UI_game_sc>().pointnumber);
				Destroy(GameObject.Find ("Treasure_Chest_Prefab4"));


			}
		}
		else if (temp.name == "Treasure_Chest_Prefab5") {
			Debug.Log ("stay");
			Debug.Log(temp.name);
			if (Input.GetKey (KeyCode.F)) {
				target++;
				GameObject.Find ("UI game").GetComponent<UI_game_sc>().pointnumber++;
				Debug.Log(GameObject.Find ("UI game").GetComponent<UI_game_sc>().pointnumber);
				Destroy(GameObject.Find ("Treasure_Chest_Prefab5"));

			}
		}
	
	}
}
