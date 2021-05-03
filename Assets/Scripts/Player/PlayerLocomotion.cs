using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLocomotion : MonoBehaviour
{
    [Header("Player Variables")]
    public float speed;
    public JellyMesh jm;
    public AudioSource audioS;
    public AudioClip[] clips;
    
    [Header("World Stuff")]
    public Transform spawn;
    
    //Privately assighned variables
    private Rigidbody rb;
    private GameObject audiolistner;
    
    //Move Input
    private float moveInputX;
    private float moveInputZ;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawn = GameObject.FindGameObjectWithTag("Spawn").transform;
        audiolistner = spawn.gameObject;
    }
    
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveInputX * speed, rb.velocity.y,moveInputZ*speed);
    }
    
    public void Move(InputAction.CallbackContext context)
    {
            moveInputX = context.ReadValue<Vector2>().x;
            moveInputZ = context.ReadValue<Vector2>().y;
    }
    public void Death()
    {
        jm.spawn(spawn);
        this.gameObject.transform.position = spawn.position;

    }
    private void OnCollisionEnter(Collision collision)
    {
        audiolistner.transform.position = this.transform.position;
        audioS.clip = clips[Random.Range(0, clips.Length)];
        audioS.Play();
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
