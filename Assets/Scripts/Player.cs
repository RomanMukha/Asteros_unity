using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float Speed = 300.0f;
    private Rigidbody2D PlayerRB;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Start ()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        //Создаем движение вверх-вниз.
        float MoveY = Input.GetAxis("Vertical");
        PlayerRB.MovePosition(PlayerRB.position + Vector2.up * MoveY * Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
}