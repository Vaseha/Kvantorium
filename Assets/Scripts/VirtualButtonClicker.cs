using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonClicer : MonoBehaviour
{
    public GameObject Сube,VirtualButton;

    // Start is called before the first frame update
    void Start()
    {
        //VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        GameObject.Find("Сube");
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Сube.SetActive (false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Сube.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Сube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}