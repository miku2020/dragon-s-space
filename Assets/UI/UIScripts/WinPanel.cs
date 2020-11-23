using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour
{
    public Boss boss;
    public GameObject winPanel;

    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<Boss>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.bossHealth <= 0)
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
