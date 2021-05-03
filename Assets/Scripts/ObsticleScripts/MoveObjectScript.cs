using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectScript : MonoBehaviour
{
    public Pose pos;

    private void Awake()
    {
        pos.position = this.transform.position;
        pos.rotation = this.transform.rotation;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag.Equals("Reset object"))
        {
            this.gameObject.transform.position = pos.position;
            this.gameObject.transform.rotation = pos.rotation;
        }
       
    }
    private void FixedUpdate()
    {
        if(this.gameObject.transform.position.y < 0)
        {
            this.gameObject.transform.position = pos.position;
            this.gameObject.transform.rotation = pos.rotation;
        }
    }
}
