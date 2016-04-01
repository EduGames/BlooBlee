using UnityEngine;
using System.Collections.Generic;

public class AmbientSong : MonoBehaviour {
	public List<int> LevelsToMute;
	public List<int> LevelsToLow;

	AudioSource audioS;
	void Awake () {
		audioS = GetComponent<AudioSource> ();
	}

	void OnLevelWasLoaded(int level) {
		if (LevelsToMute.Contains (level)) {
			iTween.ValueTo (gameObject, iTween.Hash ("from", audioS.volume, "to", 0.0f, "time", 0.5f, "onupdate", "SetVolume", "onupdatetarget", gameObject));
//		}else if(LevelsToLow.Contains (level)){
//			iTween.ValueTo (gameObject, iTween.Hash ("from", audioS.volume, "to", 0.4f, "time", 0.5f, "onupdate", "SetVolume", "onupdatetarget", gameObject));
		} else {
			iTween.ValueTo (gameObject, iTween.Hash ("from", audioS.volume, "to", 0.3f, "time", 0.5f, "onupdate", "SetVolume", "onupdatetarget", gameObject));
		}
	}

	void SetVolume(float volume){
		audioS.volume = volume;
	}
}
