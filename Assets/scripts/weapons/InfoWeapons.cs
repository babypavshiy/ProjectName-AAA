using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoWeapons : MonoBehaviour
{
    public float damage = 6f;
    public Transform player;
    public float damageInterval = 0.2f;
    private float nextDamageTime = 0f;

    void Start()
    {
        player = GameObject.Find("character").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gameObject.CompareTag("lamp")) this.transform.position = player.position;
    }
}
