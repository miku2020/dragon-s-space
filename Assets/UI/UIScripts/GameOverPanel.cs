using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GAME_OVER gameOver;

    void Start()
    {
        gameOver = GameObject.FindGameObjectWithTag("GameOver").GetComponent<GAME_OVER>();
    }

    void Update()
    {
       if (gameOver.GameOver == true)
        {
            gameOverPanel.SetActive(true);

        }
    }

    public void Respawn()
    {
        SceneManager.LoadScene("SampleScene");
    }   

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
