using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZapEvent : MonoBehaviour
{
 
    public void Hide()
    {
        this.GetComponent<RawImage>().enabled = false;
        this.GetComponent<Animator>().enabled = false; 
    }
  


}
