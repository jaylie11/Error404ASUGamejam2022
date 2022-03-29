using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFight : MonoBehaviour

{
	
	bool fightOn = false;
	private Vector3 boulderPosition;
	private Vector3 targetPosition;
	
	private void OnTriggerEnter2D(Collider2D other) {
		fightOn = true;
	}
	
	void Update() {
		
		if(fightOn){
			float timeRandom = Random.Range(0, 100);
			float positionRandom1 = Random.Range(80, 110);
			float positionRandom2 = Random.Range(80, 110);
			float positionRandom3 = Random.Range(80, 110);
			float positionRandomVert1 = Random.Range(10, 13);
			float positionRandomVert2 = Random.Range(10, 13);
			float positionRandomVert3 = Random.Range(10, 13);
			float velocityRandom = Random.Range(1, 10);
			if(timeRandom >= 99){
				
				targetPosition = new Vector3(positionRandom1, positionRandomVert1, 0);
				transform.Find("boulder1").position = targetPosition;
				
				targetPosition = new Vector3(positionRandom2, positionRandomVert2, 0);
				transform.Find("boulder2").position = targetPosition;
				
				targetPosition = new Vector3(positionRandom3, positionRandomVert3, 0);
				transform.Find("boulder3").position = targetPosition;
				
				
				//boulderPosition = new Vector3(75,4,0);
				//transform.Find("boulder1").position.x = 75.0f;
				//boulderPosition = new Vector3(positionRandom, 4, 0);
				//transform.Find("boulder1").Translate(0, -0.01f, 0);
			}
			
			//Debug.Log(randomNumber);
		}
	}
}
