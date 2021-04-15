using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGenManager : MonoBehaviour
{
    public GameObject[] rooms;
    public int numOfRooms = 0;
    public int numofRoomsToLoad = 5;
    public GameObject getRoom()
    {
        numOfRooms++;
        return rooms[Random.Range(0, rooms.Length)];
    }
}
