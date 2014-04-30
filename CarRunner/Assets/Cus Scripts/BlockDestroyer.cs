using UnityEngine;
using System.Collections;

public class BlockDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnEnable(){
		GameManager.DestroyOldFloor += removeFloor;
	}

	void OnDisable(){
		GameManager.DestroyOldFloor -= removeFloor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D collider){
		GameManager.OnDestroyFloor(collider);
	}

	void removeFloor(Collider2D collider){
		Destroy(collider.gameObject);
	}
}
