using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Canvas MainCanvas;
	public Canvas TutorialCanvas;

	void Awake(){
		
		TutorialCanvas.enabled = false;
	}

	public void TutorialOn(){

		TutorialCanvas.enabled = true;
		MainCanvas.enabled = false;
	}

	public void ReturnOn(){

		TutorialCanvas.enabled = false;
		MainCanvas.enabled = true;
	
	}

	public void LoadOn(){
		Application.LoadLevel (1);
	
	
	}

}
