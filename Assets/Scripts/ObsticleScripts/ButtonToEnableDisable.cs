using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToEnableDisable : MonoBehaviour
{
    public GameObject gObject;
    public bool enable = true;

  
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (enable && other.tag.Equals("Player") || other.tag.Equals("Player2"))
        {
            gObject.SetActive(true);
        }
        else if (!enable && other.tag.Equals("Player") || other.tag.Equals("Player2"))
        {
            gObject.SetActive(false);
        }
    }
}
