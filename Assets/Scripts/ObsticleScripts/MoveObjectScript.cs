using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectScript : MonoBehaviour
{
    public Pose pos;

    private void Awake()
    {
        pos.position = this.transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag.Equals("Reset object"))
        {
            this.gameObject.transform.position = pos.position;
        }
       
    }
}
