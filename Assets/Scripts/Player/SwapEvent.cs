using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapEvent : MonoBehaviour
{
    public GameObject arrows;
    public GameObject player;
    public GameObject OtherPlayer;
    public void Hide()
    {
        this.GetComponent<RawImage>().enabled = false;
        this.GetComponent<Animator>().enabled = false;
        Swap();
    }
    public void Swap()
    {
        Vector3 thisplayer = player.gameObject.transform.position;
        player.transform.position = new Vector3(-OtherPlayer.gameObject.transform.position.x, player.gameObject.transform.position.y, OtherPlayer.gameObject.transform.position.z);
        player.gameObject.GetComponent<JellyMesh>().spawn(player.transform);
        OtherPlayer.gameObject.transform.position = new Vector3(-thisplayer.x, player.gameObject.transform.position.y, thisplayer.z);
        OtherPlayer.gameObject.GetComponent<JellyMesh>().spawn(OtherPlayer.transform);
    }


}
