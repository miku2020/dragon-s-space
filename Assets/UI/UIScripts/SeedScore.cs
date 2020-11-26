using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeedScore : MonoBehaviour
{
    public static int SeedAmount;
    private TextMeshProUGUI SeedCounter;

    private void Start()
    {
        SeedCounter = GetComponent<TextMeshProUGUI>();
        SeedAmount = 0;

    }

    private void Update()
    {
        SeedCounter.text = "Score:" + SeedAmount;
    }
}
