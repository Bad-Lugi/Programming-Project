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
    public GameObject particles;
    public bool canMove = true;
    
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
        if (canMove)
        {
            rb.velocity = new Vector3(moveInputX * speed, rb.velocity.y, moveInputZ * speed);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
    
    public void Move(InputAction.CallbackContext context)
    {
            moveInputX = context.ReadValue<Vector2>().x;
            moveInputZ = context.ReadValue<Vector2>().y;

        
        
    }
    public void Death()
    {
        canMove = false;
        this.GetComponent<MeshRenderer>().enabled = false;
        this.GetComponent<MeshCollider>().enabled = false;
        this.GetComponentInChildren<ParticleSystem>().Play();
    }
    public void Respawn()
    {
        jm.spawn(spawn);
        this.gameObject.transform.position = spawn.position;
        canMove = true;
        this.GetComponent<MeshRenderer>().enabled = true;
        this.GetComponent<MeshCollider>().enabled = true;
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
