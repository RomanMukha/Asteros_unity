using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMoveScript : MonoBehaviour {

    public float BonusSpeed = 8;
    private Vector2 EndPosition;

    void Start()
    {
        EndPosition = new Vector2(-13.0f, Random.Range(-5, 7));
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, EndPosition, Time.deltaTime * BonusSpeed);
    }
}
