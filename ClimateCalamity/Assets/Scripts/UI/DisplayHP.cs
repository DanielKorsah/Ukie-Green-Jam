using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayHP : MonoBehaviour
{

    private TextMeshProUGUI hpText;
    private DamageHander player;

    // Start is called before the first frame update
    void Start()
    {
        hpText = gameObject.GetComponent<TextMeshProUGUI>();
        player = GameObject.FindWithTag("Player").GetComponent<DamageHander>();
    }

    // Update is called once per frame
    void Update()
    {
        hpText.SetText("HP: " + player.PlayerHealth);
    }
}
