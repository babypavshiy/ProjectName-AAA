using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp : MonoBehaviour
{
    public float damage = 20f;
    public int radius = 3;
    public float damageInterval = 1f;
    private float nextDamageTime = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D other)
    {

        if ((other.CompareTag("Enemy") || other.CompareTag("Boss")) && Time.time >= nextDamageTime)
        {
            other.GetComponent<EnemyController>().TakeDamamgeEnemy(damage);
            nextDamageTime = Time.time + damageInterval;
        }
    }
}
