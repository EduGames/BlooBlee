using UnityEngine;
using System.Collections;
using DG.Tweening;

public class EnterAnimation : MonoBehaviour {
	public float Delay;
	public float Time = 1;
	public Vector3 From;

	// Use this for initialization
	void Start () {
		transform.DOLocalMove (From, Time).From ().SetDelay(Delay);
	}
}
