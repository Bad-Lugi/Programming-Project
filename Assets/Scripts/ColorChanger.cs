using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    Material mat;
    public Material p1Mat;
    public Material p1SMat;
    public Material Solid;
    private void Awake()
    {
        if(GameObject.FindGameObjectsWithTag("Player").Length <= 1)
        {
            this.GetComponent<MeshRenderer>().material = p1Mat;
            Solid = p1SMat;

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
        if (other.tag == "SColor")
        {
            mat = Solid;
            Solid = other.GetComponent<MeshRenderer>().material;
            other.GetComponent<MeshRenderer>().material = mat;
        }

    }
}
