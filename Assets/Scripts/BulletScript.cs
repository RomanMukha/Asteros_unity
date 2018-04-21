using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    [SerializeField]
    private float _BulletSpeed = 300;
    private Vector2 _EndPosition;

    void Start()
    {
        _EndPosition = new Vector2(470.0f, transform.position.y);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _EndPosition, Time.deltaTime * _BulletSpeed);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Border")
        {
            Destroy(gameObject, 0f);
        }

        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject, 0f);
        }
    }
}
