using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Changes PlayerSpeed
	public float playerSpeed = 1.0f;
	public float jumpForce = 10.0f;
	/*
	BoxCollider2D is for the collider
	Rgidbody2d is to make the player jump
	Vector3 is to create the vector to store the position of the player
	inair is a check the player so they can't double jump. NOTE: this is actually bugged
	*/
	
	[SerializeField] private LayerMask foreGroundLayerMask;
	private BoxCollider2D BC2D;
	private Rigidbody2D RB2D;
	private Vector3 movePosition;
	//private bool inAir = false;
	private Vector3 moveDelta;
	
	//Grab the gameComponents
    private void Awake()
    {
        BC2D = GetComponent<BoxCollider2D>();
		RB2D = GetComponent<Rigidbody2D>();
    }
//####################################################################################################################################################################################

    private void Update() {
		
		//Checks to see if the rigidbody is grounded, and if the spacebar is pressed
		if (isGrounded() && Input.GetKeyDown(KeyCode.Space)) {
			RB2D.velocity = Vector3.up * jumpForce;
		}

			
	}
	private void FixedUpdate() {
		//Grab the number between -1 and 1 for Left and right movement
		float x = Input.GetAxisRaw("Horizontal");
		
//###################################################################################################################################################################################################################################################################################
		//If the last given movement was negative, it will turn the sprite left, if not, it will return it normal.
		//Note, code might change here depending on the size of the sprites
		moveDelta = new Vector3(x,0,0);
		if (moveDelta.x < 0) {
			//transform.localScale = new Vector3(-.16f,.16f,1f);
			transform.localScale = new Vector3(-1f,1f,1f);
		} else if (moveDelta.x > 0) {
			//transform.localScale = new Vector3(.16f,.16f,1f);
			transform.localScale = Vector3.one;
		}
//####################################################################################################################################################################################		
		//Note, we are not changing the Y value since that's for jumping
		movePosition = new Vector3(x,0,0);
		transform.Translate(movePosition * Time.fixedDeltaTime * playerSpeed );
	}

//####################################################################################################################################################################################
		//Cast a box from the middle of the player's boxCollider with the size of the actual boxCollider
		//0f means the box wont be rotated
		//Store it inside a RaycastHit2D called "raycastHit2d"
	private bool isGrounded() {
		RaycastHit2D raycastHit2d = Physics2D.BoxCast(BC2D.bounds.center, BC2D.bounds.size, 0f, Vector2.down, .1f,foreGroundLayerMask);
		//Debug.Log(raycastHit2d.collider);
		return raycastHit2d.collider != null;
	}
}
//####################################################################################################################################################################################
