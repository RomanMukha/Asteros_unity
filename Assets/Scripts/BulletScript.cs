using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

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
