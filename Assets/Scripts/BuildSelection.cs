using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSelection : MonoBehaviour
{
    public int building;
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    public void SelectBuilding()
    {
        
        gameController.Building = building;
        Debug.Log(gameController.Building);
        gameController = FindObjectOfType<GameController>();
        BuildManager manager = gameController.GetComponent<BuildManager>();
        manager.Bild();
    }
}