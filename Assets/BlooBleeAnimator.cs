using UnityEngine;
using System.Collections;

public class BlooBleeAnimator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("Animate", Random.Range(3,6));
	}
	
	void Animate(){
		GetComponent<Animator> ().SetTrigger ("Animate");
		Invoke("Animate", Random.Range(3,6));
	}
}
