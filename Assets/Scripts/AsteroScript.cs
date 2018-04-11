using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroScript : MonoBehaviour
{
    // Checking astero collisions with other gameObjects.
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject, 0f);
            LifeScript.lifeValue -= 1;
        }

        if (col.gameObject.tag == "Ammo")
        {
            Destroy(gameObject, 0f);
            ScoreScript.scoreValue += 1;
            // Add astero explosion animation!
        }

        if (col.gameObject.name == "DeleteArea")
        {
            Destroy(gameObject, 0f);
            DefeatCounter.defeatValue += 1;
        }
    }

}
