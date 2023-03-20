using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public Text ScoreText;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScore();
    }

     private void UpdateScore()
    {
        ScoreText.text = "Score: " + score.ToString();
    }
}
