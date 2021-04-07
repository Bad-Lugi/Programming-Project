using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    Material mat;
    public Material p1Mat;
    private void Awake()
    {
        if(GameObject.FindGameObjectsWithTag("Player").Length <= 1)
        {
            this.GetComponent<MeshRenderer>().material = p1Mat;

            GameObject.FindGameObjectWithTag("MainCamera").SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Color")
        {
            mat = this.GetComponent<MeshRenderer>().material;
            this.GetComponent<MeshRenderer>().material = other.GetComponent<MeshRenderer>().material;
            other.GetComponent<MeshRenderer>().material = mat;
        }

    }
}
