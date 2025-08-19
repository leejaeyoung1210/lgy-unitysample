using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mono.Cecil;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timeText;
    public Text scoreText;
    public Text coinText;

    public Text besttimeText;
    public Text bestscoreText;

    private float surviveTime;
    private bool isGameover;

    private int coincount;
    public int score => coincount * 10;

    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    void Update()
    {
        if (!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + (int)surviveTime;
            coinText.text = "Coin: " + coincount;
            scoreText.text = "Score: " + score;
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public int Addcoin(int i =1)
    {
        return coincount++;
    }


    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");
        float bestscore = PlayerPrefs.GetFloat("BestScore");

        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;

            PlayerPrefs.SetFloat("BestTime",bestTime);
        }
        if (score > bestscore)
        {
            bestscore = score;

            PlayerPrefs.SetFloat("BestScore", bestscore);
        }

        besttimeText.text ="Best Time: " +(int)bestTime;
        bestscoreText.text = "Best Score: " + (int)bestTime;
    }
}
