using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class VisSpriteToggle : MonoBehaviour {

	public Sprite nonVis; 
	public Sprite visSprite; 
	Image img; 

	bool visible; 

	// Use this for initialization
	void Start () {	
		visible = true; 	
		img = GetComponent<Image> (); 
	}
	
	public void SwapSprite(){

		if (visible) {
			img.sprite = nonVis; 
			visible = false; 
		} 

		else 
		{
			img.sprite = visSprite; 
			visible = true; 
		}
	}
}
