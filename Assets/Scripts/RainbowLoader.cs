using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class RainbowLoader : MonoBehaviour {
	public Image Rainbow;
	public GameObject LetsGo;

	static string SceneName = "BoyGirl";

	void Start () {
		Rainbow.fillAmount = 0;
		LetsGo.SetActive (false);
		Rainbow.DOFillAmount (1f, 1.5f).OnComplete(LunchLoadAsync);
	}

	void LunchLoadAsync(){
		StartCoroutine ("loadAsync");
	}

	private IEnumerator loadAsync()
	{
		LetsGo.SetActive (true);
		yield return new WaitForSeconds (0.7f);
		SceneManager.LoadSceneAsync (SceneName);
	}

	public static void Load(string name){
		SceneName = name;
		SceneManager.LoadScene("Loading");
	}
}
