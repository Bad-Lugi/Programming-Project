using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectScript : MonoBehaviour
{
    public Transform pos;
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag.Equals("Reset object"))
        {
            this.gameObject.transform.position = pos.position;
        }
       
    }
}
