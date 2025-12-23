using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TMP_Text timeText;
    public TMP_Text scoreText;
    public TMP_Text centerMsgText;

    private float timer = 30.0f;
    private int score = 0;
    private bool isGameOver = false;

    void Start()
    {
        if (centerMsgText != null) centerMsgText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isGameOver) return;

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 0;
            isGameOver = true;
            GameOver();
        }

        timeText.text = "Time:" + timer.ToString("F1") + "s";
        scoreText.text = "Score:" + score.ToString();
    }

    void GameOver()
    {
        if (centerMsgText != null)
        {
            centerMsgText.text = "時間到！";
            centerMsgText.gameObject.SetActive(true);
        }

        Time.timeScale = 0;

        Debug.Log("遊戲結束，所有動作已停止");
    }

    public void AddScore(int amount)
    {
        if (!isGameOver) score += amount;
    }
}