﻿using UnityEngine;
using System.Collections;

public class ProjectileTimer : MonoBehaviour {
	public int Timer;
	int timer;
	// Use this for initialization
	void Start () {
		timer = Timer;
	}
	
	// Update is called once per frame
	void Update () {
		timer--;

		if(timer <= 0){
			spawnProjectile();
		}
	}

	void spawnProjectile(){
		var projectile = GameObject.Instantiate(Resources.Load("Prefabs/Bullet"),
		                                               new Vector3(-10,Random.Range(-4.0f,-2.0f),0),
		                                               Quaternion.identity);
		timer = Timer;
	}
}