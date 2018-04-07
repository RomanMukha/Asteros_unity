using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject AsteroPrefab;
    public GameObject BonusPrefab;
    public float BonusSpawnTime = 5.0f;
    public float AsteroSpawnTime = 0.5f;
    public GameObject SpawnArea;
    Vector2 SpawnPosition;

    void Start()
    {
        InvokeRepeating("BonusSpawn", 0, BonusSpawnTime);
        InvokeRepeating("AsteroSpawn", 0, AsteroSpawnTime);
    }
    void BonusSpawn()
    {
        SpawnPosition = new Vector2(SpawnArea.transform.position.x, Random.Range(-30, 440));
        GameObject bonus = Instantiate(BonusPrefab, SpawnPosition, Quaternion.identity) as GameObject;
    }
    void AsteroSpawn()
    {
        SpawnPosition = new Vector2(SpawnArea.transform.position.x, Random.Range(-30, 440));
        GameObject astero = Instantiate(AsteroPrefab, SpawnPosition, Quaternion.identity) as GameObject;
    }
}
