using UnityEngine;
using System.Collections;

public class BoyGirlMaster : MonoBehaviour {
	public ToggleGroup toggleGroup;

	public void SetSelected(){
		RainbowLoader.Load ("Home");
	}

	// Use this for initialization
	void Awake () {
		toggleGroup.ToggleEvent += delegate(Toggle obj) {
			Invoke("SetSelected", 2.5f);
		};
	}
}
