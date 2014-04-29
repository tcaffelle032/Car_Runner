
using UnityEngine;
using System.Collections;

public class Treadmill : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GameObject ground = GameObject.Find("Ground");

		ground.transform.position -= new Vector3(.25f,0,0);

		if(ground.transform.position.x <= -ground.transform.transform.localScale.x - ground.transform.position.x){
			//moreGround(player,ground,ground.transform.position);

				
		}

	}

	public void moreGround(GameObject player,GameObject treadmill,Vector3 position){
		var randNum = Random.Range(0,10);
		var newPiece = GameObject.Instantiate(treadmill,new Vector3(randNum,treadmill.transform.position.y,0),Quaternion.identity);

		newPiece.name = "Ground";
	}
	void destroyGround(GameObject ground){
		GameObject.Destroy(ground);
	}
}
