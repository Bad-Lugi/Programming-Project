using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToEnableDisable : MonoBehaviour
{
    public GameObject gObject;
    public bool enable = true;
    public Material enablecolor;
    public Material dissablecolor;

    private void OnEnable()
    {
        if(enable)
        this.gameObject.GetComponent<MeshRenderer>().material = enablecolor;
        if(!enable)
        this.gameObject.GetComponent<MeshRenderer>().material = dissablecolor;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (enable && other.tag.Equals("Player"))
        {
            gObject.SetActive(true);
        }
        else if (!enable && other.tag.Equals("Player"))
        {
            gObject.SetActive(false);
        }
    }
}
