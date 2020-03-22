using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocks : MonoBehaviour
{
    public bool DoubleJump;

    //when a player enters this collider, they will pickup an ability
    //if this ability is X then the script will find the gameobject with the player tag and enable a dormant script on said gameobject
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (DoubleJump)
            {
                GameObject.FindWithTag("player").GetComponent<X>().enabled = true;
                Destroy(gameObject);
            }
        }
    }
    */
}
