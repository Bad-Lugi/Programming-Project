using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLine : MonoBehaviour
{
    public StartArea starter;
    public bool playerOn;
    public PlayerLocomotion pl;
    public Transform spawn;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (!playerOn)
        {
            pl = other.GetComponent<PlayerLocomotion>();
            pl.spawn = spawn;
            playerOn = true;
            starter.playersWaiting++;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name);
        if (playerOn)
        {
            playerOn = false;
            starter.playersWaiting--;
        }
    }
}
