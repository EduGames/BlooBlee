using UnityEngine;
using System.Collections;
using DG.Tweening;

public class IslandsToggle : Toggle {
	public string GameName;
	public override string GetData ()
	{
		return GameName;
	}

	void Start(){
		ToggleEvent += delegate(bool state) {
			float size = state ? 1.15f : 1;
			transform.DOScale(size, 0.5f);
		};
	}
}
