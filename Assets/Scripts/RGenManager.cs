using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGenManager : MonoBehaviour
{
    public GameObject[] rooms;
    public GameObject endRoom;
    public int numOfRooms = 0;
    public int numofRoomsToLoad = 5;
    int lastRoom= 0;
    int room;
    public GameObject getRoom()
    {

        room = Random.Range(0, rooms.Length);
        if(room == lastRoom)
        {
            room = Random.Range(0, rooms.Length);
        }
        lastRoom = room;
        numOfRooms++;
        return rooms[room];
    }
}
