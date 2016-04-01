using UnityEngine;
using System.Collections;
using DG.Tweening;

public class BubbleMovment : MonoBehaviour {
	void Start () {
		transform.DOMoveX (transform.position.x +(0.4f * Mathf.Sign(Random.Range(-1,2))), Random.Range(2f,4f))
			.SetLoops(-1, Mathf.Sign(Random.Range(-1,2)) > 0 ? LoopType.Incremental : LoopType.Yoyo)
			.SetEase(Ease.InOutQuad);
	}

}
