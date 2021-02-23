using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullStat : MonoBehaviour
{
    //call function when collider is triggered
    void OnTriggerEnter2D(Collider2D collision)
    {
        //if the collision is triggered by enemy then destroy the enemy game object
        if (collision.gameObject.CompareTag("Enemy")) { 
            Destroy(collision.gameObject);
        }
        //destroy this object
         Destroy(gameObject);
    }
}
