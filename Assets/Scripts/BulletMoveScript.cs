﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveScript : MonoBehaviour {

    public float BulletSpeed = 10;
    private Vector2 EndPosition;

    void Start()
    {
        EndPosition = new Vector2(13.0f, transform.position.y);
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, EndPosition, Time.deltaTime * BulletSpeed);
    }
}