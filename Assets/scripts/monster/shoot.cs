using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float moveSpeed = 15f;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float timer = 2f;
    public float damage = 20f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("character").transform;
        rb = this.GetComponent<Rigidbody2D>();
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            other.GetComponent<InfoPlayer>().TakeDamage(damage);
        }
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }



    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
