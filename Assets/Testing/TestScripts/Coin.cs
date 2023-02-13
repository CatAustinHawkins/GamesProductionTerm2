using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject Player;

    public GameObject WholeCoin;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin Collided With");
        if(other.tag == "Player")
        {
            Player.GetComponent<Player>().OnCoinCollection();
            Destroy(WholeCoin);
        }
    }

}