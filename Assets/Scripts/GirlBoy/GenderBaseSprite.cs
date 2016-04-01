using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class GenderBaseSprite : MonoBehaviour {
	public Sprite boySprite;
	public Sprite girlSprite;

	private SpriteRenderer spR;

	void Awake () {
		spR = GetComponent<SpriteRenderer> ();
		ApplyGender ();
	}

	public void ApplyGender(){
		if (Gender.GetCurrent() == Gender.Type.Male) {
			spR.sprite = boySprite;
		} else {
			spR.sprite = girlSprite;
		}
	}
}
