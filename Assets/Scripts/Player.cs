using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float Speed = 300.0f;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    //Store a reference to the Rigidbody2D component required to use 2D Physics.
    //private Rigidbody2D PlayerRB;

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
        Movement();

        Fire();

        Borders();

    }

    private void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Maybe we should use Input.GetAxis("Fire") or something similar?
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject;
        }
    }

    private void Movement ()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.up * Speed * verticalInput * Time.deltaTime);
        transform.Translate(Vector2.right * Speed * horizontalInput * Time.deltaTime);
    }

    private void Borders()
    // Build up ship movement borders using "if". So, we don't use physics here at all.
    {
        if (transform.position.x <= -50f)
        {
            transform.position = new Vector2(-50f, transform.position.y);
        }
        if (transform.position.x >= 400f)
        {
            transform.position = new Vector2(400f, transform.position.y);
        }
        if (transform.position.y >= 435f)
        {
            transform.position = new Vector2(transform.position.x, 435f);
        }
        if (transform.position.y <= -19f)
        {
            transform.position = new Vector2(transform.position.x, -19f);
        }
    }
}