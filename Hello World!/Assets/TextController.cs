﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text newText;
    // Start is called before the first frame update
    void Start()
    {
        newText.text = "Hello World!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello my name is Nicolas Lotruglio!";
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}