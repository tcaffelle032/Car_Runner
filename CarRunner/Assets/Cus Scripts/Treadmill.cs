
using UnityEngine;
using System.Collections;

public class Treadmill : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void OnEnable(){
		GameManager.CreateNewFloor += moreGround;
	}
	void OnDisable(){
		GameManager.CreateNewFloor -= moreGround;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject ground = GameObject.Find("Ground");

		this.gameObject.transform.position += new Vector3(.15f,0,0);

		if(ground.transform.position.x <= ground.transform.transform.localScale.x - ground.transform.position.x){
			//moreGround(player,ground,ground.transform.position);

				
		}

	}

	public void moreGround(){
		//GameObject player = GameObject.Find("Player");
		GameObject treadmill = GameObject.Find("Ground");
		var rand = Random.Range(-10,-20);

		var newPiece = GameObject.Instantiate(treadmill,new Vector3(rand,treadmill.transform.position.y,0),Quaternion.identity);

		newPiece.name = "Ground";
	}

}
