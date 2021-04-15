using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject end;
    public bool leftside;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if (leftside)
            {
                left.SetActive(true);
                end.SetActive(false);

            }
            if (!leftside)
            {
                right.SetActive(true);
                end.SetActive(false);
            }
        }
    }
}
