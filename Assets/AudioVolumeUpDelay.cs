using UnityEngine;
using System.Collections;
using DG.Tweening;

public class AudioVolumeUpDelay : MonoBehaviour {
	public float delay;
	public float volume;
	// Use this for initialization
	void OnEnable () {
		Invoke ("PlayAudio", delay);
	}

	void PlayAudio(){
		GetComponent<AudioSource> ().DOFade (volume, 1);
	}
}
