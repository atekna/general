using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof(CameraRaycaster))]
public class CursorAffordance : MonoBehaviour {

	[SerializeField] Texture2D walkCursor = null;
	[SerializeField] Texture2D swordCursor = null;
	[SerializeField] Texture2D debugCursor = null;

	[SerializeField] Vector2 cursorHotspot = new Vector2 (0,0);

	CameraRaycaster cameraRaycaster;



	void Start () {
		cameraRaycaster = GetComponent<CameraRaycaster> ();
		cameraRaycaster.layerChangeObserver += OnLayerChanged;
	}
	

	void OnLayerChanged () {

		switch (cameraRaycaster.currentLayerHit) 
		{

		case Layer.Walkable:
			Cursor.SetCursor(walkCursor,cursorHotspot,CursorMode.Auto);
			break;

		case Layer.Enemy:
			Cursor.SetCursor(swordCursor,cursorHotspot,CursorMode.Auto);
			break;

		default:
			Cursor.SetCursor(debugCursor,cursorHotspot,CursorMode.Auto);
			return;

		}
	}
}
