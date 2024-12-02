using UnityEngine;

public class MermaidController : MonoBehaviour
{
    public float rotationSpeed = 100f; // Döndürme hızı
    public float moveSpeed = 5f;       // Yukarı/aşağı hareket hızı
    public ScoreManager scoreManager;  // ScoreManager referansı

    private float timer = 0f;
    public float timeInterval = 1f;    // Her saniye bir puan ekle
    private bool canAddScore = true;   // Hareket ederken yalnızca bir kez puan ekle

    void Update()
    {
        // Her saniye bir puan eklemek için zamanlayıcıyı kontrol et
        timer += Time.deltaTime;
        if (timer >= timeInterval)
        {
            if (canAddScore)
            {
                scoreManager.AddScore(1);  // Zamanla ekleme
                canAddScore = false;       // Tekrar eklenmesini engelle
            }
        }
        else
        {
            canAddScore = true;  // Zamanlayıcı sıfırlandı, tekrar ekleme yapılabilir
        }

        // Sağ ok tuşu: saat yönünde döndür
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
           scoreManager.AddScore(1);  // Sağ ok tuşu ile her hareket ettikçe puan ekle
        }

        // Sol ok tuşu: saat yönünün tersine döndür
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            scoreManager.AddScore(1);  // Sol ok tuşu ile her hareket ettikçe puan ekle
        }

        // Yukarı ok tuşu: yukarı hareket
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            scoreManager.AddScore(2);  // Yukarı hareket ettikçe daha fazla puan ekle
        }

        // Aşağı ok tuşu: aşağı hareket
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
            scoreManager.AddScore(2);  // Aşağı hareket ettikçe puan ekle
        }
    }
}
