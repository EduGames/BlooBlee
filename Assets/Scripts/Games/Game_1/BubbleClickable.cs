using UnityEngine;
using System.Collections;

public class BubbleClickable : MonoBehaviour {
	Master_Game_1 master;

	void Awake(){
		master = GameObject.FindObjectOfType<Master_Game_1> ();
	}
	void Start () {
		GetComponent<Clickable>().ActionEvent += delegate() {
			Destroy(gameObject);
			master.OnBubbleClicked();
		};
	}
}
