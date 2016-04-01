using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HudItemsList : MonoBehaviour {
	HudItem[] items;
	public GameObject StarPrefap;

	int index;
	void Awake(){
		index = 0;
		items = new HudItem [3];
		for (int i = 0; i < items.Length; i++) {
			items [i] = Instantiate (StarPrefap).GetComponent<HudItem> ();
			items[i].transform.SetParent(transform, false);
		}
	}

	public void Add(){
		if (index >= items.Length)
			return;
		
		items [index].Change ();
		index++;
	}

	public int Count(){
		return index;
	}

	public void Reset(){
		index = 0;
		foreach(var item in items){
			item.Reset ();
		}
	}
}
