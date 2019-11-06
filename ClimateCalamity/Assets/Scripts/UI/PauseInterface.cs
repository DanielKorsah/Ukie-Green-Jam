using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseInterface : MonoBehaviour
{
    [SerializeField]
    GameObject pausePanel;
    PopDown popDown;

    private void Start()
    {
        popDown = pausePanel.GetComponent<PopDown>();
    }

    private void Update()
    {
        //toggle panel up or down with Esc key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!popDown.isDown)
            {
                Pause();
            }
            else
            {
                Unpause();
            }

        }
    }

    public void Pause()
    {
        popDown.SetDown();
        Cursor.visible = true;
        Time.timeScale = 0;
    }

    public void Unpause()
    {
        popDown.SetUp();
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
