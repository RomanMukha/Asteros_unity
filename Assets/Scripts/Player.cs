using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int Lives = 3;
    public float Speed = 20.0f;
    private Rigidbody2D PlayerRB;

    // Use this for initialization.
    private void Awake()
    {

    }

    void Start ()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame.
	void Update () {
        //Создаем движение вверх-вниз.
        float MoveY = Input.GetAxis("Vertical");
        PlayerRB.MovePosition(PlayerRB.position + Vector2.up * MoveY * Speed * Time.deltaTime);
    }
}