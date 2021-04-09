using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLine : MonoBehaviour
{
    public StartArea starter;
    public bool playerOn;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        playerOn = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name);
        playerOn = false;
    }
}
