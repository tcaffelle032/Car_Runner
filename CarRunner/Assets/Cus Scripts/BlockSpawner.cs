﻿using UnityEngine;
using System.Collections;

public class BlockSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.name =="Ground")
			GameManager.OnCreateFloor();
		else if(collider.gameObject.name =="Player")
			GameManager.OnRespawn();
		/*var newGround = GameObject.Find("Ground");
		var player = GameObject.Find("Player");
			//if(collider.gameObject.name =="Ground")
		var treadmill = newGround.GetComponent<Treadmill>();
		treadmill.moreGround(player,newGround,newGround.transform.position);*/



	}


}
