using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapEvent : MonoBehaviour
{
    public GameObject arrows;
    public GameObject player;
    public GameObject OtherPlayer;
    public void Hide()
    {
        
        arrows.SetActive(false);
    }
    public void Swap()
    {
        Vector3 thisplayer = this.gameObject.transform.position;
        player.transform.position = new Vector3(-OtherPlayer.gameObject.transform.position.x, this.gameObject.transform.position.y, OtherPlayer.gameObject.transform.position.z);
        this.gameObject.GetComponent<JellyMesh>().spawn(this.transform);
        OtherPlayer.gameObject.transform.position = new Vector3(-thisplayer.x, this.gameObject.transform.position.y, thisplayer.z);
        OtherPlayer.gameObject.GetComponent<JellyMesh>().spawn(OtherPlayer.transform);
    }


}
