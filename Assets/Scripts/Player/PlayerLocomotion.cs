using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLocomotion : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInputX;
    private float moveInputZ;
    public JellyMesh jm;

    public Transform spawn;


    private Rigidbody rb;

    private bool isGrounded;
    public Transform groundCheck;
    public Transform groundCheck2;

    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpValue;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawn = GameObject.FindGameObjectWithTag("Spawn").transform;

    }

    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, whatIsGround);
        if (!isGrounded)
        {
            isGrounded = Physics.CheckSphere(groundCheck2.position, checkRadius, whatIsGround);
        }


        rb.velocity = new Vector3(moveInputX * speed, rb.velocity.y,moveInputZ*speed);

    }

    private void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpValue;

        }
        if (this.gameObject.transform.position.y < -10)
        {
            Death();
        }
    }
    public void Move(InputAction.CallbackContext context)
    {
        moveInputX = context.ReadValue<Vector2>().x;
        moveInputZ = context.ReadValue<Vector2>().y;
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && extraJumps > 0 && isGrounded == false)
        {
            //particle.Play();
            rb.velocity = Vector3.up * jumpForce;
            extraJumps--;
        }
        else if (context.performed && extraJumps > 0)
        {

            rb.velocity = Vector3.up * jumpForce;
            extraJumps--;
        }
        else if (context.performed && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector3.up * jumpForce;
        }
    }
    public void Death()
    {
        this.gameObject.transform.position = spawn.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("death"))
        {
            GetComponent<JellyMesh>().enabled = false;
            Death();
            GetComponent<JellyMesh>().enabled = true;
        }
    }
}
