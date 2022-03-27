using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackeysMovement : MonoBehaviour
{
    public CharacterController2D controller;
	public float playerSpeed = 1.0f;
	
	private float horizontalMove = 0f;
	bool jump = false;
	
	private void update() {
		horizontalMove = Input.GetAxisRaw("Horizontal") * playerSpeed;
		
		if (Input.GetButtonDown("Jump")) {
			jump = true;
		}
	}
	
	private void FixedUpdate() {
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}
}
