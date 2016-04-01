using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Master_Game_1 : MonoBehaviour {
	public HudItemsList Stars;
	public HudItemsList Hearts;

	BubblesSpawner Spawner;
	bool GameStarted = false;

	public GameObject GameOverPanel, WinPanel;

	int indexClicked;
	int indexTotal;

	public Image stars;

	public AudioSource IntroAudio;

	void Awake(){
		GameOverPanel.SetActive (false);
		WinPanel.SetActive (false);
		Spawner = GetComponent<BubblesSpawner> ();
	}

	void StartGame(){
		indexTotal = 0;
		indexClicked = 0;
		GameStarted = true;
		Spawner.SpawnBubble ();
		GetComponent<AudioSource> ().Play ();
		WinPanel.SetActive (false);
		GameOverPanel.SetActive (false);
		IntroAudio.Stop ();
	}

	public void Restart(){
		Hearts.Reset ();
		Stars.Reset ();

		StartGame ();
	}

	public void OnBubbleClicked(){
		if (GameStarted) {
			indexClicked++;
			if(indexClicked % 9 == 0)
				Stars.Add ();
			BubbleProcessed ();
		}
		else
			StartGame ();
	}

	public void OnBubbleEscaped(){
		BubbleProcessed ();
		Hearts.Add ();
		if(Hearts.Count() >= 3)
			GameOver();
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (other.gameObject);
		OnBubbleEscaped ();
	}

	void BubbleProcessed(){
		indexTotal++;

		if (indexTotal >= 28) {
			Win ();
		}
	}

	void GameOver(){
		Spawner.Reset ();
		GetComponent<AudioSource> ().Stop ();
		GameOverPanel.SetActive (true);
	}

	void Win(){
		stars.sprite = Resources.Load<Sprite> ("Stars_"+Stars.Count());
		Spawner.Reset ();
		WinPanel.SetActive (true);

		PlayerPrefs.SetInt ("Game_1", Mathf.Max (Stars.Count(), PlayerPrefs.GetInt("Game_1",0)));
	}

	public void NextLevel(){
		RainbowLoader.Load ("Home");
	}

	public void Back(){
		RainbowLoader.Load ("LevelSelector");
	}
}
