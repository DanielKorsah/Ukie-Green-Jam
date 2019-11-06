using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public string levelName;
    public void Load()
    {
        SceneManager.LoadScene(levelName);
    }
}
