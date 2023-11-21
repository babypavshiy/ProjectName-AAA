using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class moveDalnoboyshik : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public SpriteRenderer spriteRender;
    public float temp;

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
        if ((direction * 100).magnitude > 700)
        {
            direction.Normalize();
            movement = direction;
        }
        else
        {
            movement = new Vector3(0, 0, 0);
        }
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