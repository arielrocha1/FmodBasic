using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentBehavior : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float direction;
    public float speed;
    public bool facingRight;
    public Animator anim;

    private void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        if (direction < 0)
        {
            facingRight = false;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if(direction > 0)
        {
            facingRight = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        Run();
    }

    private void Run()
    {
        if (direction == 0)
        {
            anim.SetBool("Running",false);
        }
        else
        {
            anim.SetBool("Running",true);
        }

        rb2d.velocity = new Vector2(direction * speed, rb2d.velocity.y);
    }
}
