using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeedScript : MonoBehaviour
{
    private TextMeshProUGUI seedText;
    public bool showSeedText = true;
    // Start is called before the first frame update
    void Start()
    {
       seedText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
    if(showSeedText == true)
    {
     seedText.SetText("Seed is Ready");
    }
    else
    {
        seedText.SetText("Not Ready");
    }
}
}
