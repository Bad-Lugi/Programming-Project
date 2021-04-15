using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGen : MonoBehaviour
{
    public GameObject[] gameObjects;
    public RGenManager rgm;
    private void Awake()
    {
        rgm = GameObject.FindGameObjectWithTag("RGenManager").GetComponent<RGenManager>();
        if(rgm.numOfRooms < rgm.numofRoomsToLoad)
        Instantiate(rgm.getRoom(), transform.position, Quaternion.identity);
    }
}
