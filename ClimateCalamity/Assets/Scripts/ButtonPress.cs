using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour {

	public void PlayGameClicked()
    {
        SceneManager.LoadScene("Integration Testing");
    }
}