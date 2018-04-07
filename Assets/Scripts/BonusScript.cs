using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusScript : MonoBehaviour {

    // Checking bonus collisions with other gameObjects.
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject, 0f);
            // Hp ++
        }
        if (col.gameObject.name == "DeleteArea")
        {
            Destroy(gameObject, 0f);
            // Nothing special happens.
        }
    }
}
