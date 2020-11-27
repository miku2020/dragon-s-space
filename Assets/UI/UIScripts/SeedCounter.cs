using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeedCounter : MonoBehaviour
{
    public static int SeedAmount;
    private TextMeshProUGUI Seedcounter;

     void Start()
    {
        Seedcounter = GetComponent<TextMeshProUGUI>();
        SeedAmount = 0;

    }

     void Update()
    {
        Seedcounter.text = "Score:" + SeedAmount; 
    }


}
