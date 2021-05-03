using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTagChanger : MonoBehaviour
{
    public bool playerOn;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
            other.gameObject.layer = 13;
            playerOn = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name);
            other.gameObject.layer = 12;
            playerOn = false;
    }
}
