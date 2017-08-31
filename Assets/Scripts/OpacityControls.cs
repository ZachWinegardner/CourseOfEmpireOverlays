using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class OpacityControls : MonoBehaviour {

	CanvasGroup CG; 
	public Slider slider; 
	float slideAlpha; 

	void Start () {
		CG = GetComponent<CanvasGroup> (); 
	}
	
	void Update () {
		
		slideAlpha = slider.value; 
		CG.alpha = slideAlpha; 
	}
}
