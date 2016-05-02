using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	void OnGUI() {
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
	}

}
