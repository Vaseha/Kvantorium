using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonClicer : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Сube,VirtualButton;

    // Start is called before the first frame update
    void Start()
    {
        //VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        GameObject.Find ("Сube");
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