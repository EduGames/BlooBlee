using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FloatingIslandsMaster : MonoBehaviour {
	public ToggleGroup tg;

	void Awake () {
		tg.ToggleEvent += delegate(Toggle obj) {
			Invoke("StartGame", 1.5f);
		};
	}

	public void StartGame(){
		SceneManager.LoadScene (tg.GetCurrentToggleData ());
//		RainbowLoader.Load( tg.GetCurrentToggleData () );
	}

	public void GoBAck(){
		RainbowLoader.Load( "BoyGirl" );
	}
}
