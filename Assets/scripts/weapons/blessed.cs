using UnityEngine;

public class blessed : MonoBehaviour
{
    public GameObject prefab;
    private int maxSpawn = 1;

    public Transform player;

    public float timeSpawn = 2f;
    private float timer;

    public float lifeTime = 0.8f;
    public float distance = 3;

    private void Start()
    {
        player = GameObject.Find("character").transform;
        timer = timeSpawn;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector2 pos = new Vector2(player.position.x, player.position.y);
            timer = timeSpawn;
            Instantiate(prefab, pos + Random.insideUnitCircle * distance, Quaternion.identity);
        }
    }
}