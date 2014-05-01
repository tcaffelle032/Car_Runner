using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnEnable(){
		GameManager.RespawnPlayer += playerDied;
	}
	void OnDisable(){
		GameManager.RespawnPlayer -= playerDied;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void playerDied(){
		StartCoroutine("playerDead");
	}
	
	IEnumerator playerDead(){
		yield return new WaitForSeconds(3);
		createPlayer();
	}


	void createPlayer(){
		var player = GameObject.Instantiate(Resources.Load("Prefabs/Player"));
		player.name = "Player";
	}
}
