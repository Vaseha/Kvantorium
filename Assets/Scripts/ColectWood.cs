using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ColectWood : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public int resorce;
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("Laciebtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ResourcesController.wood += resorce;
        Debug.Log("BTN Pressed");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

        Debug.Log("Btn Realesed");
    }
    // Update is called once per frame
    void Update()
    {

    }
}