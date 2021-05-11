using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

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
                InstantDeath(Player);
                break;
            case 5:
                Debug.Log("Swap");
                SwapPos(Player);
                break;
            default:
                Debug.Log("Death");
                InstantDeath(Player);
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
    public void InstantDeath(GameObject Player)
    {
        Player.GetComponent<PlayerLocomotion>().Death();
    }
    public void SwapPos(GameObject Player)
    {
        Vector3 thisplayer = this.gameObject.transform.position;
        this.gameObject.transform.position = new Vector3(-Player.gameObject.transform.position.x, this.gameObject.transform.position.y, Player.gameObject.transform.position.z);
        this.gameObject.GetComponent<JellyMesh>().spawn(this.transform);
        Player.gameObject.transform.position = new Vector3(-thisplayer.x, this.gameObject.transform.position.y, thisplayer.z);
        Player.gameObject.GetComponent<JellyMesh>().spawn(Player.transform);
    }
    
}
