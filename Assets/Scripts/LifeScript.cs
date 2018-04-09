using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeScript : MonoBehaviour {

    public static int lifeValue = 2;
    Text life;

    void Start()
    {
        life = GetComponent<Text>();
    }

    void Update()
    {
        life.text = "LIVES: " + lifeValue;
    }
}
