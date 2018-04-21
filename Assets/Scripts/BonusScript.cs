using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusScript : MonoBehaviour {

    [SerializeField]
    private float _BonusSpeed = 300;
    private Vector2 _EndPosition;

    void Start()
    {
        _EndPosition = new Vector2(-470.0f, Random.Range(-270, 270));
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position = Vector2.MoveTowards(transform.position, _EndPosition, Time.deltaTime * _BonusSpeed);
    }

    // Checking bonus collisions with other gameObjects.
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject, 0f);
            LifeScript.lifeValue += 1;
        }

        if (col.gameObject.name == "DeleteArea")
        {
            Destroy(gameObject, 0f);
            // Nothing special happens.
        }

        if (col.gameObject.tag == "Ammo")
        {
            Destroy(gameObject, 0f);
            // Add bonus explosion animation!
        }
    }
}
