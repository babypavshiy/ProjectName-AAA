using UnityEngine;

public class spawnMoster: MonoBehaviour
{
    public GameObject enemyPrefab;
    public int maxEnemy = 5;

    public float timeSpawn = 2f;
    private float timer;

    public float distance = 3;

    private void Start()
    {
        timer = timeSpawn;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeSpawn;
            if (transform.childCount < maxEnemy)
            {
                Instantiate(enemyPrefab, Random.insideUnitCircle * distance, Quaternion.identity, transform);
            }
        }
    }
}