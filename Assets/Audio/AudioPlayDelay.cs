using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayDelay : MonoBehaviour {
	public float delay;
	public bool Everytime = false;
	// Use this for initialization
	void OnEnable () {
		Invoke ("PlayAudio", delay);
	}

	void PlayAudio(){
		if(Everytime || AudioMaster.CouldPlay(GetComponent<AudioSource> ().clip))
			GetComponent<AudioSource> ().Play ();
	}
}
