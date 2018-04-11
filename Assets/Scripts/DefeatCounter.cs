using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefeatCounter : MonoBehaviour {

    public static int defeatValue = 0;
    Text defeat;

    void Start()
    {
        defeat = GetComponent<Text>();
    }

    void Update()
    {
        defeat.text = "DEFEAT COUNTER: " + defeatValue;
    }
}
