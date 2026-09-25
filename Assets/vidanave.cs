using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;     // Prefab do meteoro grande
    public float spawnInterval = 2f;    // Tempo entre cada meteoro
    public float spawnRangeX = 8f;      // Até onde pode nascer na horizontal
    public float spawnY = 6f;           // Altura que os meteoros nascem

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnMeteor();
            timer = 0f;
        }
    }

    void SpawnMeteor()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);

        Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
    }
}
