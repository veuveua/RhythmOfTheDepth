using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText; // TextMesh Pro referansı
    public int score = 0;           // Puan değişkeni

    void Start()
    {
        // Başlangıçta skoru sıfırla ve güncelle
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void SubtractScore(int amount)
    {
        score -= amount;
        if (score < 0) score = 0; // Puan sıfırın altına düşmesin
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
