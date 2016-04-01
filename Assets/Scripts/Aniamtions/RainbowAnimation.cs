using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class RainbowAnimation : IslandElementEnterAnimation {
	Image image;
	// Use this for initialization
	void Awake(){
		image = GetComponent<Image> ();
	}

	void Start () {
		image.fillAmount = 0;
	}
	
	protected override void Aniamtion ()
	{
		image.DOFillAmount (1, 1);
	}
}
