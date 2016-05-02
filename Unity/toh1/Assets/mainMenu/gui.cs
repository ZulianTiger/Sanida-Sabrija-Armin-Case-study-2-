using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {

	public void ChangeScene(string SceneName){

		Application.LoadLevel(SceneName);

	}
}
