using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalRotate : MonoBehaviour
{

    public float rotateUpSpeed;

    // Update is called once per frame
    void Update()
    {
        rotateUp();  
    }

    void rotateUp()
    {
        transform.Rotate(Vector3.forward, rotateUpSpeed * Time.deltaTime, Space.World);
    }
}
