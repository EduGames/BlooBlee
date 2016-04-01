using UnityEngine;
using System.Collections;
using DG.Tweening;

public class IslandEnterAnimation : MonoBehaviour {
	public float delay;
	SpriteRenderer spR;

	void Start () {
		spR = GetComponent<SpriteRenderer> ();
		if(spR != null)
			spR.enabled = false;
		
		Invoke ("StartAnimation", delay);
	}

	void StartAnimation(){
		if(spR != null)
			spR.enabled = true;
		transform.DOScale (Vector3.one * 0.1f, 1f).From ().SetEase (Ease.OutBounce).OnComplete(OnComplete);
	}

	void OnComplete(){
		foreach (var el in GetComponentsInChildren<IslandElementEnterAnimation>()) {
			el.AnimateElement ();
		}
	}
}
