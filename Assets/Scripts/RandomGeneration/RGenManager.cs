using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGenManager : MonoBehaviour
{
    public GameObject[] rooms;
    public GameObject endRoom;
    public GameObject checkpointRoom;
    public int numOfRooms = 0;
    public int numofRoomsToLoad = 5;
    public int roomsBetweenCheckpoints = 3;
    int lastRoom= 0;
    int room;
    public GameObject getRoom()
    {
        if (numOfRooms % roomsBetweenCheckpoints == roomsBetweenCheckpoints-1)
        {
            numOfRooms++;
            return checkpointRoom;
        }
        else
        {
            room = Random.Range(0, rooms.Length);
            if (room == lastRoom)
            {
                room = Random.Range(0, rooms.Length);
            }
            lastRoom = room;
            numOfRooms++;
            return rooms[room];
        }
    }
}
