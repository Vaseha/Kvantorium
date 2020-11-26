using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    GameController gameController;
    public GameObject building1;
    public GameObject building2;
    public GameObject building3;
    public GameObject building4;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    public void Bild()
    {
        switch (gameController.Building)
        {
            case 1:
                if (ResourcesController.food >= 10)
                {
                    ResourcesController.food = ResourcesController.food - 10;
                    Instantiate(building1, spawnPoint1.transform.position, Quaternion.identity);
                }
                else Debug.Log("Недостаточно ресурсов");

                break;

            case 2:
                if (ResourcesController.wood >= 10)
                {
                    ResourcesController.wood = ResourcesController.wood - 10;
                    Instantiate(building2, spawnPoint2.transform.position, Quaternion.identity);
                }
                else Debug.Log("Недостаточно ресурсов");

                break;

            case 3:
                if (ResourcesController.stone >= 10)
                {
                    ResourcesController.stone = ResourcesController.stone - 10;
                    Instantiate(building3, spawnPoint3.transform.position, Quaternion.identity);
                }
                else Debug.Log("Недостаточно ресурсов");

                break;

            case 4:
                if (ResourcesController.iron >= 10)
                {
                    ResourcesController.iron = ResourcesController.iron - 10;
                    Instantiate(building4, spawnPoint4.transform.position, Quaternion.identity);
                }
                else Debug.Log("Недостаточно ресурсов");

                break;
        }
    }
}