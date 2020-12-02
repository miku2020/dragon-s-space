using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour
{
    public GameObject boss;
    public GameObject winPanel; 

    // Update is called once per frame
    void Update()
    {
        if (boss.GetComponent<Boss>().bossHealth <= 0)
        {
            Invoke("Win", 3f);
        }        
    }

    public void Win()
    {
        winPanel.SetActive(true);
    }

    public void Credits()
    {
        SceneManager.LoadScene("CREDITS");
    }
}
