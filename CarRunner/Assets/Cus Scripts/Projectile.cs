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
}
