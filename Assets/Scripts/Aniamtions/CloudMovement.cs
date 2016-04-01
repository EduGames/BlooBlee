using UnityEngine;
using System.Collections;
using DG.Tweening;
public class CloudMovement : MonoBehaviour {
	Vector3 world;
	// Use this for initialization
	void Start () {
		world = Camera.main.ScreenToWorldPoint(new Vector3 (Camera.main.pixelWidth
			, Camera.main.pixelHeight
			, 0));
		Move ();
	}
	
	// Update is called once per frame
	void Move () {
		transform.position = new Vector3(-world.x - 2,transform.position.y,0);
		transform.DOLocalMoveX (world.x + 1, Random.Range (6, 10)).OnComplete (Move).SetEase (Ease.Linear);
	}
}
