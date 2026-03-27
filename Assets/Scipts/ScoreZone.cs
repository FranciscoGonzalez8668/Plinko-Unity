using UnityEngine;
using TMPro;

public class ScoreZone : MonoBehaviour
{
    public int points = 100;
    public TextMeshProUGUI pointsText; // Arrastrá el texto hijo desde el Inspector

    void Start()
    {
        // Muestra el valor automáticamente al iniciar
        if (pointsText != null)
            pointsText.text = points.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            other.gameObject.SetActive(false);
            ScoreManager.Instance.AddScore(points);
        }
    }
}