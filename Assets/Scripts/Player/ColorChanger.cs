using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [Header("Materials")]
    public Material PlayerOneMaterial;
    public Material PlayerOneSolidMaterial;
    public Material PlayerOneParticleMaterial;
    public Material CurrentSolidColor;

    //PlaceHolder Material
    private Material mat;
    private void Awake()
    {
        if(GameObject.FindGameObjectsWithTag("Player").Length <= 1)
        {
            this.GetComponent<MeshRenderer>().material = PlayerOneMaterial;
         CurrentSolidColor = PlayerOneSolidMaterial;
            this.GetComponentInChildren<ParticleSystemRenderer>().material = PlayerOneParticleMaterial;

            GameObject.FindGameObjectWithTag("MainCamera").SetActive(false);
        }
        else
        {
            GameObject.FindGameObjectWithTag("StartDialog").SetActive(false);
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
            mat = CurrentSolidColor;
         CurrentSolidColor = other.GetComponent<MeshRenderer>().material;
            other.GetComponent<MeshRenderer>().material = mat;
        }
        if (other.tag == "PColor")
        {
            mat = this.GetComponentInChildren<ParticleSystemRenderer>().material;
            this.GetComponentInChildren<ParticleSystemRenderer>().material = other.GetComponent<MeshRenderer>().material;
            other.GetComponent<MeshRenderer>().material = mat;
        }

    }
}
