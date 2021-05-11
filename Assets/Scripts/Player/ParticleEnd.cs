using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEnd : MonoBehaviour
{
    public PlayerLocomotion pl;
    public bool respawn;
    private void OnParticleSystemStopped()
    {
        Debug.Log("Stopped");
        if(!respawn)
            pl.Respawn();
        this.GetComponentInChildren<ParticleEnd>().respawn = false;
    }


}
