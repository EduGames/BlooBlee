using UnityEngine;
using System.Collections;

public class BubblesSpawner : MonoBehaviour {
	public GameObject Bubble;
	int indexSpawned = 0;
	int isRight = 1;

	public void Reset(){
		indexSpawned = 0;
		transform.DestroyChildren ();
		CancelInvoke ("SpawnBubble");
	}

	public void SpawnBubble(){
		if (indexSpawned >= 28)
			return;

		isRight = isRight * -1;
		Vector3 world = Camera.main.ScreenToWorldPoint(new Vector3 (Camera.main.pixelWidth
			, Camera.main.pixelHeight
			, 0));

		GameObject bubble = (Instantiate (Bubble, new Vector3 (Random.Range (isRight*(world.x - 1), isRight*0.7f), -world.y - (indexSpawned / 5f), 0), Quaternion.identity)
			as GameObject);
		bubble.transform.SetParent (transform);
		indexSpawned++;
		bubble.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Game_1/Letters/Letter"+indexSpawned.ToString("00"));
		Invoke ("SpawnBubble", 0.75f);
	}
}
