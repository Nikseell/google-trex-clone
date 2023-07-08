using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public int gameSpeed = 10;

    private int score;

    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();

        if (score % 5 == 0)
        {
            gameSpeed += 1;
        }
    }
}
