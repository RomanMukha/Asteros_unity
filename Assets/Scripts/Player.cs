using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //Floating point variable to store the player's movement speed.
    public float Speed = 300.0f;
    //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private Rigidbody2D PlayerRB;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Start ()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        PlayerRB.AddForce(movement * Speed);

        //PlayerRB.MovePosition(PlayerRB.position + Vector2 *  Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject;
    }
}