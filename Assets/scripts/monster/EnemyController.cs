using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float health = 60f;
    public float damage = 20f;
    private float nextDamageTime = 0f;
    [HideInInspector]
    public GameObject player;
    public float healthBack = 5f;
    public float exp = 20f;

    void Start()
    {
        player = GameObject.Find("character");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "character")
        {
            other.GetComponent<InfoPlayer>().TakeDamage(damage);
        }
        if (other.CompareTag("blessed"))
        {
            TakeDamamgeEnemy(other.GetComponent<InfoWeapons>().damage);
        }
        if (other.CompareTag("scythe"))
        {
            TakeDamamgeEnemy(other.GetComponent<InfoWeapons>().damage);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("lamp") && Time.time >= nextDamageTime)
        {
            nextDamageTime = Time.time + other.GetComponent<InfoWeapons>().damageInterval;
            TakeDamamgeEnemy(other.GetComponent<InfoWeapons>().damage);
        }


    }

    public void TakeDamamgeEnemy(float damage)
    {
        health -= damage;
        if (health < 0f)
        {
            DieEnemy();
        }
    }

    private void DieEnemy()
    {
        player.GetComponent<InfoPlayer>().addExp(exp);
        player.GetComponent<InfoPlayer>().TakeHealth(healthBack);
        Destroy(gameObject);
    }
}


