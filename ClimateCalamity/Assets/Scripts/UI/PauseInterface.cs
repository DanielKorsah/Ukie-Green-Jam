using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseInterface : MonoBehaviour
{
    [SerializeField]
    GameObject pausePanel;
    PopDown pausePopDown;
    

    private void Start()
    {
        pausePopDown = pausePanel.GetComponent<PopDown>();
    }

    private void Update()
    {
        //toggle panel up or down with Esc key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pausePopDown.isDown)
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
        pausePopDown.SetDown();
        Cursor.visible = true;
        Time.timeScale = 0;
    }

    public void Unpause()
    {
        pausePopDown.SetUp();
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
