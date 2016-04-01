using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LogoAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.DOLocalRotate (Vector3.one * 10f, 3).SetEase (Ease.OutBounce).OnComplete(Beats);
//		transform.DOScale (Vector3.one * 0.6f, 2).From().SetEase (Ease.OutBounce).OnComplete(Beats);
	}
	
	void Beats(){
//		transform.DOScale (1.02f, 0.3f).SetLoops (-1, LoopType.Yoyo);
	}
}
