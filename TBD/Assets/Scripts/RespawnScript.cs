﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    [SerializeField] private Transform player;
	[SerializeField] private Transform respawnPoint;
	
  
	
	private void OnTriggerEnter2D(Collider2D other) {
		player.transform.position = respawnPoint.transform.position;
		
	}
}
