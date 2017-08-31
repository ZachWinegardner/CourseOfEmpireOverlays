using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayersManager : MonoBehaviour {

	public GameObject[] paintingLayers; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LayerButtonPressed (int index){

		if (paintingLayers [index].transform.GetSiblingIndex() != 4) {
			
			paintingLayers [index].transform.SetSiblingIndex (4); 
		}
	}

	public void ToggleVisibility(int index){

		if (!paintingLayers [index].activeSelf) {
			paintingLayers [index].SetActive (true); 
		}
		else
			paintingLayers [index].SetActive (false); 

	}
}
