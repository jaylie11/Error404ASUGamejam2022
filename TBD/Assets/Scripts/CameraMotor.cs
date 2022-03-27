using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
	//Find the gameobject to look at. This meanse we can maybe change it later by a trigger or something
    public Transform lookAt;
	
	private void LateUpdate(){
		
		//The position of the player 
		float deltaX = lookAt.position.x;
		float deltaY = lookAt.position.y;
		
		
		//Use the position of the player to move the camera
		transform.position = new Vector3(deltaX, deltaY,-10);
		
		
	}
}
