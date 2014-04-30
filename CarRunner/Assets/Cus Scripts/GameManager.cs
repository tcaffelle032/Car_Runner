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
}
