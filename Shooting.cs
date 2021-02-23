using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    
   

    // Update is called once per frame
    void Update()
    {
        //if user clicks on the Fire1 button then call shoot()
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
       //create bullet gameobject
       GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
       //add force to the bullet to move
       rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

       //destroy the bullet after time 2f 
       Destroy(bullet, 2);
    }
}
