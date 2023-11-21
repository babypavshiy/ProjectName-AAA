using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suicideScythe : MonoBehaviour
{
    private float timer;
    public scythe life;
    void Start()
    {
        life = FindObjectOfType<scythe>();
        timer = life.lifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = life.lifeTime;
            Destroy(gameObject);
        }
    }
}
