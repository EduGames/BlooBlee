using UnityEngine;
using System.Collections.Generic;

public class NotToDie : MonoBehaviour {
	public static List<string> types = new List<string> ();

	void Awake () {
		if (types.Contains (gameObject.name)) {
			Destroy (gameObject);
		} else {
			DontDestroyOnLoad (gameObject);	
			types.Add (gameObject.name);
		}
	}
}
