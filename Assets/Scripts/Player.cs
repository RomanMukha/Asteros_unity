using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //Floating point variable to store the player's movement speed.
    public float Speed = 300.0f;
    //Store a reference to the Rigidbody2D component required to use 2D Physics.
    //private Rigidbody2D PlayerRB;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    // Use this for initialization
    private void Start()
    {
        // current pos = new position
        transform.position = new Vector2(400, 200);

        //PlayerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.up * Speed * verticalInput * Time.deltaTime);
        transform.Translate(Vector2.right * Speed * horizontalInput * Time.deltaTime);

        // Build up ship movement borders using "if". So, we don't use physics here at all.
        if (transform.position.x <= -50f)
        {
            transform.position = new Vector2(-50f, transform.position.y);
        }
        else if (transform.position.x >= 400f)
        {
            transform.position = new Vector2(400f, transform.position.y);
        }
        else if (transform.position.y >= 435f)
        {
            transform.position = new Vector2(transform.position.x, 435f);
        }
        else if (transform.position.y <= -19f)
        {
            transform.position = new Vector2(transform.position.x, -19f);
        }

        // Invoke shooting.
        if (Input.GetKeyDown(KeyCode.Space)) // Maybe we should use Input.GetAxis("Fire") or something similar?
        {
            Fire();
        }
    }

    private void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject;
    }
}