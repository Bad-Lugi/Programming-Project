using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public PlayerLocomotion pl;
    public Transform spawn;
    private void OnTriggerEnter(Collider other)
    {
        pl = other.GetComponent<PlayerLocomotion>();
        pl.spawn = spawn;
    }
}
