using UnityEngine;
using System.Collections;
using DG.Tweening;

public class GirlBoyToggle : Toggle {

	public Gender.Type type;
	public GameObject[] objects;

	public override string GetData ()
	{
		return type.ToString ();
	}

	void Start(){
		ToggleEvent += delegate(bool state) {
			float size = state ? 1.3f : 1;

			foreach(var obj in objects){
				obj.transform.DOScale(size, 0.5f);
			}
			if(state){
				GetComponentInChildren<Animator>().SetTrigger("Animate");
				Gender.SetCurrent(type);
			}
		};
	}
}
