using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZapEvent : MonoBehaviour
{
    public GameObject Zap;
    public GameObject player;
    public void Hide()
    {
        this.GetComponent<RawImage>().enabled = false;
        this.GetComponent<Animator>().enabled = false;
        Death();
    }
    public void Death()
    {
        player.GetComponent<PlayerLocomotion>().Death();
    }


}
