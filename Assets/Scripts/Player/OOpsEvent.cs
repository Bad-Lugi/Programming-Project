using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OOpsEvent : MonoBehaviour
{
    public void Hide()
    {
        this.GetComponent<RawImage>().enabled = false;
        this.GetComponent<Animator>().enabled = false; 
    }
  


}
