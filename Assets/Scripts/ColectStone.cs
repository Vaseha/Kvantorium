using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ColectStone : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public int resorce;
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("stone");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ResourcesController.stone += resorce;
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