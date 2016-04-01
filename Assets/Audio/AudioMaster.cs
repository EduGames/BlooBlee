using UnityEngine;
using System.Collections.Generic;

public class AudioMaster {
	public static List<string> clipsPlayed = new List<string>();

	public static bool CouldPlay(AudioClip clip){
		bool result = false;
		if(clipsPlayed.Contains(clip.name)== false){
			clipsPlayed.Add (clip.name);
			result = true;
		}
		return result;
	}
}
