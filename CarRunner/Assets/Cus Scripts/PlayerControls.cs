using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	Animator playerAnimation;
	// Use this for initialization
	void Start () {
		playerAnimation = this.gameObject.GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) || Input.touchCount >=1){

			playerAnimation.SetBool("IsJumping",true);
			playerJump();

		}

	}

	void playerJump(){
		var playerPos = this.gameObject.transform;
		Vector3 jump = new Vector3(0,2,0);
		playerPos.position += jump;				
		playerAnimation.SetBool("IsJumping",true);

	}

	void OnCollisionEnter2D(Collision2D collider){
		if(collider.gameObject.name =="Ground"){
			playerAnimation.SetBool("IsJumping",false);
			//Debug.Log("False");

		}
	}


}
