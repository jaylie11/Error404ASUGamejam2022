using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Changes PlayerSpeed
	public float playerSpeed = 1.0f;
	//Changes Jumpforce of the player.
	//Note I had the gravity on the player at 3
	public float jumpForce = 10.0f;
	/*
	BoxCollider2D is for the collider
	Rgidbody2d is to make the player jump
	Vector3 is to create the vector to store the position of the player
	inair is a check the player so they can't double jump. NOTE: this is actually bugged
	*/
	private BoxCollider2D BC2D;
	private Rigidbody2D rb2D;
	private Vector3 movePosition;
	private bool inAir = false;
	
	//Grab the gameComponents
    private void Start()
    {
        BC2D = GetComponent<BoxCollider2D>();
		rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() { 
		
		//Grab the number between -1 and 1 for Left and right movement
		float x = Input.GetAxisRaw("Horizontal");
		
		//Grabs the current velocity of the player. It's used later for checking the isAir bool
		Vector3 testLog = rb2D.velocity;
		//float y = Input.GetAxisRaw("Vertical");
		
		if (Input.GetButtonDown("Jump")) {
			Debug.Log("jumped");
			//If the player is not in the air, allow them to jump
			if (!inAir)
				rb2D.AddForce(transform.up * (32 * jumpForce));
			inAir = true;
		}
		
		//Checks if the player lands on the floor
		if (testLog.y == 0.0f) {
			inAir = false;
			Debug.Log("airClear");
		}
		
		//If the player is moving left, make the sprite invert to match it
		if (x < 0) {
			transform.localScale = new Vector3(-.16f,.16f,1f);
		} else {
			transform.localScale = new Vector3(.16f,.16f,1f);
		}
		
		//Note, we are not changing the Y value since that's for jumping
		movePosition = new Vector3(x,0,0);
		
		transform.Translate(movePosition * Time.fixedDeltaTime * playerSpeed );

		
		
    }
}
