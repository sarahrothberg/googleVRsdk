using UnityEngine;
using System.Collections;

public class EnvironmentSwitcher : MonoBehaviour {

	public GameObject[] scenes;
	int currentSceneNumber;

	//to use this script with GVR pugin, attach it to a game object in the scene
	//add an event trigger to the game object
	//add a pointerclick (or pointenter, if you prefer) to the event trigger
	//drag the game object you attached this script into the game object field
	//choose this script and whichever function you'd ike to use 

	//function below sets the first item in the array to active, and the others to inactive
	//can be used to switch environments or simple switch in and out objects
	//to use, attach to gameobject and drag the items you would like to switch onto the array
	public void ChangeScenes(){
		Debug.Log ("switched to" + currentSceneNumber);
		scenes [currentSceneNumber].SetActive (false);
		currentSceneNumber++;
		if (currentSceneNumber == scenes.Length+1) {
			currentSceneNumber = 0;
		}
		scenes [currentSceneNumber].SetActive (true);
	}


}
