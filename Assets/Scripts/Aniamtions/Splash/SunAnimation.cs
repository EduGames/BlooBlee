using UnityEngine;
using System.Collections;
using DG.Tweening;
public class SunAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		transform.DOScale (1.1f, 1).SetLoops (-1, LoopType.Yoyo);//.SetEase(Ease.InOutBounce);
		transform.DOLocalRotate(new Vector3(0,0,-360), 70, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
	}
}
