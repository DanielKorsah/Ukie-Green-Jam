using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClickExample : MonoBehaviour {
	public Button yourButton;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		SceneManager.LoadScene("Master");
	}

	void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
	}
}