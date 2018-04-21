using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float _Speed = 300.0f;
    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private float ShootRate = 0.2f;
    private float CanShoot = 0f;

    private void Start()
    {
        transform.position = new Vector2(0, 0);
    }

    private void Update()
    {
        Movement();

        Shoot();
    }

    private void Shoot()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0)) && Time.time > CanShoot)
        {
            CanShoot = Time.time + ShootRate;
            GameObject bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity) as GameObject;
        }
    }

    private void Movement ()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.up * _Speed * verticalInput * Time.deltaTime);
        transform.Translate(Vector2.right * _Speed * horizontalInput * Time.deltaTime);

        // Build up ship movement borders using "if". So, we don't use physics here at all.
        if (transform.position.x <= -420f)
        {
            transform.position = new Vector2(-420f, transform.position.y);
        }
        if (transform.position.x >= 0f)
        {
            transform.position = new Vector2(0f, transform.position.y);
        }
        if (transform.position.y >= 220f)
        {
            transform.position = new Vector2(transform.position.x, 220f);
        }
        if (transform.position.y <= -240f)
        {
            transform.position = new Vector2(transform.position.x, -240f);
        }
    }
}