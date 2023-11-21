using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class moveGoat : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public SpriteRenderer spriteRender;
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("character").transform;
        rb = this.GetComponent<Rigidbody2D>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("blessed") && temp == 0)
        {
            temp = moveSpeed;
            moveSpeed = 0f;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("blessed") && temp != 0)
        {
            moveSpeed = temp;
            temp = 0;
        }
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
        if (movement.x < 0)
        {
            spriteRender.flipX = false;
        }

        if (movement.x > 0)
        {
            spriteRender.flipX = true;
        }
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}