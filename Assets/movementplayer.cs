using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class movementplayer : MonoBehaviour
{
    public float playermovementSpeed = 5f;
    SpriteRenderer spriteRd;
    Animator animatorController;

    Rigidbody2D rbbody;
    
    void Start()
    {
        rbbody = GetComponent<Rigidbody2D>();
        spriteRd = GetComponent<SpriteRenderer>();
        animatorController = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");

        rbbody.velocity = new Vector2 (movementX, rbbody.velocity.y);

        if (Mathf.Abs(rbbody.velocity.x) > 0)
        {
            animatorController.SetInteger("switchAni",1);
        }

        else 
        {
            animatorController.SetInteger("switchAni", 0);
        }

        if (rbbody.velocity.x < 0)
        {
            spriteRd.flipX = true;
        }

        if (rbbody.velocity.x > 0)
        {
            spriteRd.flipX = false;
        }
      
    }
}
