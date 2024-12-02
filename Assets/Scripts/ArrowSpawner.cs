using UnityEngine;

using System.Collections.Generic;

public class ArrowSpawner : MonoBehaviour
{
   public List<GameObject> arrowPrefabs;// Düşman prefabı
public float spawnRate = 1f; // Düşman doğma süresi (saniye)
public float spawnRange = 5f; // Spawn noktasından uzaklık (yarıçap)
public float spawnDistance = 10f; // Sahne dışında doğma mesafesi
public Transform spawnArea; // Spawn noktası (boş GameObject)

private Transform player;

public int maxArrows = 20; // Maksimum düşman sayısı

private int currentArrowCount = 0; // Sahnedeki mevcut düşman sayısı

void Start()
{
    //player = GameObject.FindGameObjectWithTag("Player").transform; // Oyuncuyu bul
    InvokeRepeating("SpawnArrow", 1f, spawnRate); // Düşmanları tekrar tekrar doğur

}

void SpawnArrow()
{
    Debug.Log("SpawnEnemy çağrıldı!"); // Kontrol için
    // Eğer sahnede maksimum düşman varsa yeni düşman oluşturma
    if (currentArrowCount >= maxArrows)
    {
        return;
    }

    // Rastgele bir açı belirle
    float angle = Random.Range(0f, 360f);

    

    //Vector3 spawnPosition = player.position + (Quaternion.Euler(0, 0, angle) * Vector3.up) * spawnDistance;

    // Rastgele bir pozisyon hesapla (spawnArea pozisyonuna göre)
    // Vector2 randomOffset = Random.insideUnitCircle * spawnRange;
    Vector3 spawnPosition = new Vector3(spawnArea.position.x, spawnArea.position.y, 0);

    // Düşmanı oluştur
    int randomIndex = Random.Range(0, arrowPrefabs.Count);
        GameObject selectedArrowPrefab = arrowPrefabs[randomIndex];

        // Prefab'ı sahneye doğur
        GameObject arrow = Instantiate(selectedArrowPrefab, spawnPosition, Quaternion.identity);
    // Debug.Log("Düşman oluşturuldu: " + enemy.name);

    // Düşman sayısını artır
    currentArrowCount++;

    
}

// Update is called once per frame
void Update()
{
}
}
