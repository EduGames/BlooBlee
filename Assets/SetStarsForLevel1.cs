using UnityEngine;
using System.Collections;

public class SetStarsForLevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("LevelStars_1/Stars_"+PlayerPrefs.GetInt("Game_1",0));
		print (PlayerPrefs.GetInt("Game_1",0));
	}
}
