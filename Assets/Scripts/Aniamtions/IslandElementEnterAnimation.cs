using UnityEngine;
using System.Collections;

public abstract class IslandElementEnterAnimation : MonoBehaviour {
	public float delay;
	public void AnimateElement (){
		Invoke ("Aniamtion", delay);
	}
	protected abstract void Aniamtion ();
}
