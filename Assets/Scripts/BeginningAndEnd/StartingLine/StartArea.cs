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

            for(int i = 0; i<GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                GameObject.FindGameObjectsWithTag("Player")[i].GetComponent<PlayerLocomotion>().boosts = 3;
                GameObject.FindGameObjectsWithTag("Player")[i].GetComponent<PlayerLocomotion>().UpdateTrail();
            }
        } 
    }
}
