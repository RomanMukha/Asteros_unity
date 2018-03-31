using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public GameObject BulletPrefab;
    public float BulletSpawnTime = 1.0f;
    public GameObject Player;

    void Start()
    {
        InvokeRepeating("BulletSpawn", 0, BulletSpawnTime);
    }
    void BulletSpawn()
    {
        transform.position = Player.transform.position;
        GameObject bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity) as GameObject;
    }


}
 