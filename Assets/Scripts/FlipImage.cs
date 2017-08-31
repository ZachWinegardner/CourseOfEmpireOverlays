using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipImage : MonoBehaviour {

	RectTransform RT; 
	public KeyCode key; 
	Vector3 scale;


	// Use this for initialization
	void Start () {
		RT = GetComponent<RectTransform> (); 
		SetScale ();  	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey(key)){ 

			// Flip Vertically
			if (Input.GetKeyDown(KeyCode.DownArrow) && scale.y < 0){				
				FlipY (); 				
			}

			if (Input.GetKeyDown(KeyCode.UpArrow) && scale.y > 0){				
				FlipY (); 				
			}


			//Flip Horizontally
			if (Input.GetKeyDown(KeyCode.RightArrow) && scale.x < 0){				
				FlipX (); 				
			}

			if (Input.GetKeyDown(KeyCode.LeftArrow) && scale.x > 0){				
				FlipX (); 				
			}

		}
	}

	void FlipY(){
		float newScale = scale.y * -1; 
		RT.localScale = new Vector3 (scale.x, newScale, scale.z);
		SetScale(); 
	}

	void FlipX(){
		float newScale = scale.x * -1; 
		RT.localScale = new Vector3 (newScale, scale.y, scale.z);
		SetScale(); 		 
	}

	void SetScale(){
		scale = RT.localScale; 
	}
}
