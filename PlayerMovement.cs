using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; //Floating point variable to store the player's movement speed.

    public Rigidbody2D rb; //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public Camera cam; //reference camera for mouse aiming 

    private bool _isRight = true; // assign boolean isRight to true 


    Vector2 movement;
    Vector2 mousePosi;
    // Use this for initialization
    void Start()
    {

    }
    private void Update()
    {
        // get user inputs for mouse and movement
        movement.x = Input.GetAxis("Horizontal"); 
        movement.y = Input.GetAxis("Vertical");
        mousePosi = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
        Vector2 lookDirection = mousePosi - rb.position;
        //function that returns angle between x axis and a 2d vector starting at 0
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg -90f;
        rb.rotation = angle;
        // flip the gameobject when moving from left to right or right to left
        if (movement.x > 0 && _isRight == false) Flip();
        if (movement.x < 0 && _isRight == true) Flip();
    }
    private void Flip()
    {
        // If isRight is true make it false and vice versa
        _isRight = !_isRight;

        // Multiply the player's x local scale by -1 to flip
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
