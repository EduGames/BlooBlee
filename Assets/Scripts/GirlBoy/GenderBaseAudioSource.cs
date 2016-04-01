using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class GenderBaseAudioSource : MonoBehaviour {
	public AudioClip boy;
	public AudioClip girl;

	private AudioSource target;
	public bool PlayOnAwake = false;


	void Awake(){
		target = GetComponent<AudioSource> ();
	}
	void OnEnable () {
		ApplyGender ();
	}

	public void ApplyGender(){
		if (Gender.GetCurrent() == Gender.Type.Male) {
			target.clip = boy;
		} else {
			target.clip = girl;
		}
		if (PlayOnAwake)
			target.Play ();
	}
}
