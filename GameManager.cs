using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject heart1, heart2, heart3, gameOver;

    public int health; 

    public int score; 

    public TextMeshProUGUI scoreText;    

    void Start()
    {
        health = 3;
        
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    void Update()
    {
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:     
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            default:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;                        
        }
    }

    private void Awake()
    {
        // If there is no existing instance of GameManager
        if (instance == null)
        {
            // Set this instance as the active GameManager
            instance = this;
        }
        else
        {
            // Destroy the new GameManager instance if one already exists
            Destroy(gameObject); 
        }
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score : " + score.ToString();
    }
    
    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score : " + score.ToString();
    }

}
