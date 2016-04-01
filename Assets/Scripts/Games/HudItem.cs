using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HudItem : MonoBehaviour {
	public Sprite OriginalSprite;
	public Sprite NewSprite;

	public void Change(){
		GetComponent<Image> ().sprite = NewSprite;
	}

	public void Reset(){
		GetComponent<Image> ().sprite = OriginalSprite;
	}
}
