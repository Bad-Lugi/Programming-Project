using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public new string tag = "Music";
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(tag);
        if (objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
