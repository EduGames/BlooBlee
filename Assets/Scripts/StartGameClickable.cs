using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Clickable))]
public class StartGameClickable : MonoBehaviour {
	Clickable clickable;
	public string SceneName;
	public bool Direct;

	public float delay = 0;

	void Awake(){
		clickable = GetComponent<Clickable> ();

		clickable.ActionEvent += delegate() {
			Invoke("Load", delay);
		};
	}

	void Load(){
		if(Direct)
			SceneManager.LoadScene(SceneName);
		else{
			RainbowLoader.Load( SceneName );
		}
	}
}
