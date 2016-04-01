using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CharacterAnimation : MonoBehaviour {
	public float ShowDelay;
	Clickable clickable;
	// Use this for initialization
	void Awake () {
		clickable = GetComponent<Clickable> ();
		clickable.ActionEvent += delegate() {
			transform.DOShakePosition(1, 0.2f);
		};

		transform.DOScale (0.0f, 2).From ().SetDelay (ShowDelay).SetEase (Ease.OutElastic);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
