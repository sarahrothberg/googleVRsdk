using UnityEngine;
using System.Collections;

public class SimpleTrigerableFunctions : MonoBehaviour {

	public GameObject activatableComponent;

	public void turnOnGO(){
		activatableComponent.SetActive (true);
	}

	public void turnOffGO(){
		activatableComponent.SetActive (false);
	}

	public void turnOnComponent(){
		activatableComponent.SetActive (false);
	}

	public void turnOffComponent(){
		activatableComponent.SetActive (false);
	}

	//Note: SetActive is for gameObjects and enabled is for Components on the Object
	public void changeMatColorToCyan(){
		Renderer rend = GetComponent<Renderer>();
		rend.material.color = Color.cyan; 
	}

	public void changeMatColorToRed(){
		Renderer rend = GetComponent<Renderer>();
		rend.material.color = Color.red; 
	}
}
