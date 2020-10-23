using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int Building { get; set; }
    public int food { get; set; } = 100;
    public int wood { get; set; } = 100;
    public int stone { get; set; } = 100;
    public int iron { get; set; } = 100;

    // Update is called once per frame
    void Update()
    {

    }
}