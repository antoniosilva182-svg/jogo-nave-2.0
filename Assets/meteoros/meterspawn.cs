using UnityEngine;

public class Meteor : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    [Header("Quebra do Meteoro")]
    public GameObject smallerMeteorPrefab; // Prefab do meteoro menor
    public int numberOfSmallMeteors = 2;   // Quantos pedaços vão nascer

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            BreakMeteor();
        }
    }

    void BreakMeteor()
    {
        // Se tiver prefab de meteoro menor, cria os pedaços
        if (smallerMeteorPrefab != null)
        {
            for (int i = 0; i < numberOfSmallMeteors; i++)
            {
                // Cria o meteoro menor numa posição um pouco aleatória
                Vector3 offset = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), 0);
                Instantiate(smallerMeteorPrefab, transform.position + offset, Quaternion.identity);
            }
        }

        // Destroi o meteoro atual
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
    }
}