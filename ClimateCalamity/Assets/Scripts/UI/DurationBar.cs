using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DurationBar : MonoBehaviour
{

    public GameObject Player;

    [SerializeField]
    private float levelLength;
    private Image bar;

    private bool fight = true;

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
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            InFight();
        }
    }

    void InFight()
    {
        if(fight)
        {
            Debug.Log("Fight Started");
        Player.GetComponent<BossSpawn>().inFight = true;
        fight = false;
        }
    }
}
