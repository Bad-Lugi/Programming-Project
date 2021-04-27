using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
{
    public GameObject end;
    public bool leftside;
    public GameObject[] platform;
    ColorChanger cc;


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag.Equals("Player"))
        {
            end.SetActive(false);
            cc = other.GetComponent<ColorChanger>();
            for (int i = 0; i < platform.Length; i++)
            {
                platform[i].GetComponent<MeshRenderer>().material = cc.CurrentSolidColor;
            }
        }
    }
}
