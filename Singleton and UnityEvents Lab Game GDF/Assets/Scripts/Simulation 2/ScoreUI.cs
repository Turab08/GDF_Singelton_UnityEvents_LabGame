using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TMP_Text scoreText;

    void Start()
    {
        ScoreManager.Instance.OnScoreChanged.AddListener(UpdateScore);
    }

    void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
