using UnityEngine;
using System.Collections;

public class OnBackButtonClicked : MonoBehaviour {
	public string GameName;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) { 
			Back ();
		}
	}

	public void Back(){
		if (GameName == ""){
			Application.Quit ();
		}else {
			RainbowLoader.Load (GameName);
		}
	}
}
