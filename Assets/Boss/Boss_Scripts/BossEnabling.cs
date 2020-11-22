using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnabling : MonoBehaviour
{
    public GameObject boss;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Map_lerp>().shouldlerp == false)
        {
            boss.SetActive(true);
        }

    }
}
