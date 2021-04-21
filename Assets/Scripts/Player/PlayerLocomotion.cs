﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLocomotion : MonoBehaviour
{
    [Header("Player Locomotion Variables")]
    public float speed;
    
    [Header("World Stuff")]
    public Transform spawn;
    
    //Privately assighned variables
    private Rigidbody rb;
    
    //Move Input
    private float moveInputX;
    private float moveInputZ;
    public JellyMesh jm;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawn = GameObject.FindGameObjectWithTag("Spawn").transform;

    }
    
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveInputX * speed, rb.velocity.y,moveInputZ*speed);
    }
    
    public void Move(InputAction.CallbackContext context)
    {
        if (canMove)
        {
            moveInputX = context.ReadValue<Vector2>().x;
            moveInputZ = context.ReadValue<Vector2>().y;
        }
    }
    public void Death()
    {
        jm.spawn(spawn);
        this.gameObject.transform.position = spawn.position;;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("death"))
        {
            
            Death();
            
        }
    }
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag.Equals("death"))
        {

            Death();

        }
    }

}
