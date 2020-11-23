using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GAME_OVER : MonoBehaviour
{

    public bool GameOver;
    private bool shouldupdate;
    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        shouldupdate = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (shouldupdate == true)
        {
            if (GameOver == true)
            {
                Debug.Log("GameOver");
                //GetComponent<Renderer>().enabled = true;
                shouldupdate = false;
            }
        }
    }
}
//Mikael Huhtakangas