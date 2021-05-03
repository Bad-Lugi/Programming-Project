using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalRotate : MonoBehaviour
{

    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        rotate();  
    }

    void rotate()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }
}
