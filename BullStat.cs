using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullStat : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) { 
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        
    }
}
