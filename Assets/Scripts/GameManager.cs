using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;  // Skor
    public TMP_Text scoreText;  // Skor Text
    public GameObject arrowSpawner;  // Okları spawn eden objeyi bağlantılandır

    private bool isArrowInPosition = false;

    void Update()
    {
        // Kullanıcı aşağı ok tuşuna bastığında skoru artır
        if (Input.GetKeyDown(KeyCode.DownArrow) && isArrowInPosition)
        {
            score += 10; // Puan artır
            UpdateScoreText();
            isArrowInPosition = false;  // Sadece bir ok için geçerli
        }
    }

    // Skoru TextMesh Pro UI'ye yazdır
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    // Ok, sınır objesinin üzerine geldiğinde buraya gelmeli
    public void OnArrowPassedThrough()
    {
        isArrowInPosition = true;  // Ok sınırdan geçtiğinde doğru tuşa basılmasını kontrol et
    }

    // Yanlış tuşa basıldığında puanı düşür
    public void OnWrongInput()
    {
        score -= 5;
        UpdateScoreText();
    }
}
