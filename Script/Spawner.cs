using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public BoxCollider2D spawnBoundsCollider;
    public float spawnDelayMin = 1f;
    public float spawnDelayMax = 5f;
    public GameObject player;

    float spawnTimer = 0f;
    float currentSpawnDelay = 0f;
    float spawnDelayIncrement = 0.01f;

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= currentSpawnDelay)
        {
            spawnTimer = 0f;

            currentSpawnDelay = Random.Range(spawnDelayMin, spawnDelayMax);
            // Agar spawn di dalam collider
            Vector2 min = spawnBoundsCollider.bounds.min;
            Vector2 max = spawnBoundsCollider.bounds.max;

            Vector2 spawnPoint = new Vector2(
                Random.Range(min.x, max.x),
                Random.Range(min.y, max.y));

            if (player.GetComponent<Collider2D>().OverlapPoint(spawnPoint))
            {

                return;
            }
            Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);
        }
        currentSpawnDelay += spawnDelayIncrement * Time.deltaTime;
    }
}