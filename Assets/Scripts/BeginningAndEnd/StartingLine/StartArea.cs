using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartArea : MonoBehaviour
{
    public int playersWaiting;
    public GameObject wall;
    public GameObject Cage;
    public int playersNeeded = 2;
    void Update()
    {
        if (playersWaiting >= playersNeeded)
        {
            wall.SetActive(false);
            Cage.SetActive(true);
        } 
    }
}
