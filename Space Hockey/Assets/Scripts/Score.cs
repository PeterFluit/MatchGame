using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public enum Score
    {
        AiScore,
        PlayerScore
    }

    public Text AiScoreText, PlayerScoreTxt;
    private int aiScore, playerScore;

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
            AiScoretxt.text = (++aiScore).ToString();
        else
        {
            PlayerScoreTxt.text = (++playerScore).ToString();
        }
    }
}
