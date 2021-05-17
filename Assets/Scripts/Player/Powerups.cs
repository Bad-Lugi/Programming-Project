﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Powerups : MonoBehaviour
{
    private GameObject[] Players;
    public GameObject SpinObject;
    public GameObject ZapObject;

    private void Awake()
    {
        SpinObject = GameObject.FindGameObjectWithTag("Spin");
        ZapObject = GameObject.FindGameObjectWithTag("Zap");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("PowerUp"))
        {
            this.gameObject.tag = "TempTag"; 
            SelectPowerUp(GameObject.FindGameObjectWithTag("Player"));
            this.gameObject.tag = "Player";
            Destroy(other.gameObject);
        }
    }

public void SelectPowerUp(GameObject Player)
    {  
        switch (Random.Range(0,6))
        {
            case 0:
                Debug.Log("rainbow");
                rainbowColor();
                break;
            case 1:
                Debug.Log("Add boosts");
                AddBoosts();
                break;
            case 2:
                Debug.Log("lv1 debuff");
                PlayerSpeedDebuf(Player);
                break;
            case 3:
                Debug.Log("Lv2 Debuf");
                PlayerSpeedDebufStrong(Player);
                break;
            case 4:
                Debug.Log("Death");
                Zap(Player);
                break;
            case 5:
                Debug.Log("Swap");
                StartSwapPos(Player);
                break;
            default:
                Debug.Log("Death");
                Zap(Player);
                break;
        }
        
        
    }
    public void rainbowColor()
    {
        this.gameObject.GetComponent<ColorChanger>().RainbowColor();
    }
    public void AddBoosts()
    {
        int number = Random.Range(1, 3);
        this.gameObject.GetComponent<PlayerLocomotion>().boosts += number;
        this.gameObject.GetComponent<PlayerLocomotion>().UpdateTrail();
        Debug.Log("Added " + number + " Boosts");
    }
    public void PlayerSpeedDebuf(GameObject Player)
    {
        Player.GetComponent<PlayerLocomotion>().speedDebuff = 0.5f;
    }
    public void PlayerSpeedDebufStrong(GameObject Player)
    {
        Player.GetComponent<PlayerLocomotion>().speedDebuff = 0f;
    }
    public void Zap(GameObject Player)
    {
        Player.GetComponent<PlayerLocomotion>().Death();
        ZapObject.GetComponent<Animator>().enabled = true;
        ZapObject.GetComponent<RawImage>().enabled = true;
    }
    public void StartSwapPos(GameObject Player)
    {
        SpinObject.GetComponent<Animator>().enabled = true;
        SpinObject.GetComponent<RawImage>().enabled = true;
        SpinObject.GetComponent<SwapEvent>().player = this.gameObject;
        SpinObject.GetComponent<SwapEvent>().OtherPlayer = Player;
    }
    
}
