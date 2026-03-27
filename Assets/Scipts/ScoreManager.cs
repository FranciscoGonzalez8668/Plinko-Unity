using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // Para acceder desde ScoreZone sin referencias
    public TextMeshProUGUI scoreText;

    private int totalScore = 0;

    void Awake()
    {
        Instance = this;
    }

    public void AddScore(int points)
    {
        totalScore += points;
        Debug.Log("Puntos añadidos: " + points + " | Total Score: " + totalScore);
        scoreText.text = "Score: " + totalScore;
    }
}
