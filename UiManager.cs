using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject gameOver;

    public static int scoreCount;
    public void RestartLevel()
    {
        Debug.Log("Restarting game");        
        Time.timeScale = 1;
        GameManager.instance.health = 3;

        GameManager.instance.ResetScore();

        gameOver.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        GameManager.instance.score = 0;
        
    }
        public void ExitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
