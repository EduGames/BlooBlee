using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoButton : MonoBehaviour {
	public ToggleGroup toggleGroup;
	Button btn; 

	// Use this for initialization
	void Awake () {
		btn = GetComponent<Button> ();
		btn.interactable = false;
		toggleGroup.ToggleEvent += delegate(Toggle obj) {
			btn.interactable = true;
		};
	}
}
