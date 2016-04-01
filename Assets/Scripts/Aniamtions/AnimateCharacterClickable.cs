using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Clickable))]
public class AnimateCharacterClickable : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Awake () {
		GetComponent<Clickable>().ActionEvent += delegate() {
			anim.SetTrigger("Animate");
		};
	}
}
