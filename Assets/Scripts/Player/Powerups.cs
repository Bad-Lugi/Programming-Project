using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    private GameObject[] Players;

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
        Debug.Log(Player.gameObject.transform.position.x - this.gameObject.transform.position.x);
        if (Player.gameObject.transform.position.x > this.gameObject.transform.position.x + 40)
        {
            switch (Random.Range(0, 3))
            {
                case 0:
                    InstantDeath(Player);
                    break;
                case 1:
                    PlayerSpeedDebufStrong(Player);
                    break;
                default:
                    PlayerSpeedDebuf(Player);
                    break;
            }
        }
        else if (Player.gameObject.transform.position.x > this.gameObject.transform.position.x+20)
        {
            switch (Random.Range(0, 5))
            {
                case 0:
                    InstantDeath(Player);
                    break;
                case 1:
                    PlayerSpeedDebufStrong(Player);
                    break;
                default:
                    PlayerSpeedDebuf(Player);
                    break;
            }
        } else if (Player.gameObject.transform.position.x > this.gameObject.transform.position.x)
        {
            switch (Random.Range(0, 10))
            {
                case 0:
                    InstantDeath(Player);
                    break;
                case 1:
                    PlayerSpeedDebufStrong(Player);
                    break;
                default:
                    PlayerSpeedDebuf(Player);
                    break;
            }
        }else if (Player.gameObject.transform.position.x <= this.gameObject.transform.position.x)
        {
            PlayerSpeedDebuf(Player);
        }
    }
    public void PlayerSpeedDebuf(GameObject Player)
    {
        Player.GetComponent<PlayerLocomotion>().speedDebuff = 0.5f;
    }
    public void PlayerSpeedDebufStrong(GameObject Player)
    {
        Player.GetComponent<PlayerLocomotion>().speedDebuff = 0f;
    }
    public void InstantDeath(GameObject Player)
    {
        Player.GetComponent<PlayerLocomotion>().Death();
    }
}
