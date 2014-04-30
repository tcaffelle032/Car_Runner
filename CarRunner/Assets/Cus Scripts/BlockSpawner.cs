using UnityEngine;
using System.Collections;

public class BlockSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D collider){
		GameManager.OnCreateFloor();
		/*var newGround = GameObject.Find("Ground");
		var player = GameObject.Find("Player");
			//if(collider.gameObject.name =="Ground")
		var treadmill = newGround.GetComponent<Treadmill>();
		treadmill.moreGround(player,newGround,newGround.transform.position);

			GameObject.Destroy(collider.gameObject);*/

	}
}
