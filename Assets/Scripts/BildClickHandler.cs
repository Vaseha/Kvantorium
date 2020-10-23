using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BildClickHandler : MonoBehaviour
{
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseDoun ()
    {
       gameController = FindObjectOfType<GameController>();
        BuildManager manager = gameController.GetComponent<BuildManager>();
        manager.Bild();
    }
}