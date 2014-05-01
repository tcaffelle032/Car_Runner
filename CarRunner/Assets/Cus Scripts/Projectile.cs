using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float ProjectileSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.position += new Vector3(ProjectileSpeed,0,0);
	}

	void OnTriggerEnter2D(Collider2D collider){
		GameObject g_Object = collider.gameObject;
		
		if(g_Object.name == "Player"){
			Destroy(g_Object);
			GameManager.OnRespawn();
			/*GameObject manager = GameObject.Find("Manager");
			PlayerSpawner spawner = manager.GetComponent<PlayerSpawner>();
			spawner.playerDied();*/

		}
	}

}
