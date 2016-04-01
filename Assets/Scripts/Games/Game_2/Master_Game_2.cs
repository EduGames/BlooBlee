using UnityEngine;
using System.Collections.Generic;

public class Master_Game_2 : MonoBehaviour {
	public List<DropZone> dropZones;
	public List<Draggable> draggables;

	void Awake(){
		foreach (var d in draggables) {
			d.IsDraggable = true;
			d.onDragEnded += delegate(Draggable self, DropZone dropedOn) {
				return (dropZones.IndexOf (dropedOn) == draggables.IndexOf (self));
			};
		}
	}

}
