using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public GameObject[] pointsToMoveTowards;
    public float speed;
    int ID =0;
    Vector3 to;
    private void Awake()
    {
        to = getPos();
        this.transform.position = pointsToMoveTowards[0].transform.position;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, to, speed*Time.deltaTime);
        if(this.transform.position == to)
        {
            to = getPos();
        }
    }
  
    Vector3 getPos()
    {
        ID++;
        if (ID >= pointsToMoveTowards.Length)
            ID = 0;
        return pointsToMoveTowards[ID].transform.position;

    }
}
