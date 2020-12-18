using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ColectFood : MonoBehaviour
{
    public GameObject text;
    public int resorce;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        ResourcesController.food += resorce;
    }
}