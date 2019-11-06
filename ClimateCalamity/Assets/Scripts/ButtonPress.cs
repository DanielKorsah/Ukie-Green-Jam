using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour {

	public void PlayLevel1Clicked()
    {
        SceneManager.LoadScene("Alfie");
    }
    public void PlayLevel2Clicked()
    {
        SceneManager.LoadScene("Level2");
    }
}