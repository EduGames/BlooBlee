using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ButtonGlowAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.DOScale (1.1f, 1).SetLoops (-1, LoopType.Yoyo);

		GetComponent<Clickable>().StartEvent += delegate() {
			transform.DOKill();
		};
		GetComponent<Clickable>().EndEvent += delegate() {
			transform.localScale = Vector3.one;
			transform.DOScale (1.1f, 1).SetLoops (-1, LoopType.Yoyo);
		};

	}
}
