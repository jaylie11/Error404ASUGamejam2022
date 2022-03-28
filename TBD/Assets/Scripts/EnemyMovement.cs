using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 1.0f;
	public float frequency = 5f;
	public float magnitude = 5f;
	public float offset = 0f;
	
	private Vector3 startingPosition;
	private BoxCollider2D BC2D;
	private Rigidbody2D RB2D;
	
	
	private void Awake() {
		BC2D = GetComponent<BoxCollider2D>();
		RB2D = GetComponent<Rigidbody2D>();
		startingPosition = transform.position;
	}
	
	
	private void Update() {
		transform.position = startingPosition - transform.right * Mathf.Sin(Time.time * frequency + offset) * magnitude;
	}

}
