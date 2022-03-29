using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatoforms : MonoBehaviour
{
	
	private PlatformEffector2D effector;
	public float waitTime;
	
    // Start is called before the first frame update
    private void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    private void Update()
    {
		float y = Input.GetAxisRaw("Vertical");
		
		// if (y < 0)) {
			// waitTime = 0.5f;
		// }
        if (y < 0) {
			//waitTime = 0.5f;
			// if (waitTime <= 0) {
				// effector.rotationalOffset = 180f;
				// waitTime = 0.5f;
			// } else {
				// waitTime -= Time.deltaTime;
			// }
			effector.rotationalOffset = 180f;
		}
		
		if (Input.GetButton("Jump")) {
			effector.rotationalOffset = 0;
		}
    }
}
