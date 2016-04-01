using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class GenderBaseAnimator : MonoBehaviour {
	public RuntimeAnimatorController boyCtrl;
	public RuntimeAnimatorController girlCtrl;

	private Animator animator;

	void Awake () {
		animator = GetComponent<Animator> ();
		ApplyGender ();
	}

	public void ApplyGender(){
		if (Gender.GetCurrent() == Gender.Type.Male) {
			animator.runtimeAnimatorController = boyCtrl;
		} else {
			animator.runtimeAnimatorController = girlCtrl;
		}
	}
}
