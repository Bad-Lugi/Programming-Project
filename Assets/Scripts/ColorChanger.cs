﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    Material mat;

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
