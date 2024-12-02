using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float moveSpeed = 1f; // Okların hareket hızı
    public float moveTime = 7f; // Okların inme süresi
    public GameManager gameManager;

    private float moveTimer = 0f;

    void Update()
    {
        // Okları aşağıya hareket ettir
        moveTimer += Time.deltaTime;
        if (moveTimer <= moveTime)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        else
        {
            // Ok zaman bittiğinde yok olmasını sağla
            Destroy(gameObject);
        }
    }
}
