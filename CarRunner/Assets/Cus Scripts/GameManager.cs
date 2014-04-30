using UnityEngine;
using System.Collections;

public static class GameManager{

	// Use this for initialization
	public delegate void RespawnFloor();
	public static event RespawnFloor CreateNewFloor;
	public static void OnCreateFloor(){
		if(CreateNewFloor != null)
			CreateNewFloor();
	}

	public delegate void DestroyFloor(Collider2D collider);
	public static event DestroyFloor DestroyOldFloor;
	public static void OnDestroyFloor(Collider2D collider){
		if(DestroyOldFloor != null)
			DestroyOldFloor(collider);
	}

	public delegate void PlayerRespawn();
	public static event PlayerRespawn RespawnPlayer;
	public static void OnRespawn(){
		if(RespawnPlayer != null){
			RespawnPlayer();
		}
	}
}
