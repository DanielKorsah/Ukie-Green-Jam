using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DurationBar : MonoBehaviour
{


    [SerializeField]
    private float levelLength;
    private Image bar;

    private void Start()
    {
        bar = gameObject.GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        float percentageComplete = Time.time / levelLength;
        bar.fillAmount = percentageComplete;

        if (percentageComplete >= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
