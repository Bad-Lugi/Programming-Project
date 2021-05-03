using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEnd : MonoBehaviour
{
    public PlayerLocomotion pl;

    private void OnParticleSystemStopped()
    {
        Debug.Log("Stopped");
        pl.Respawn();
    }


}
