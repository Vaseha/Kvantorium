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
                if (gameController.food >= 10)
                {
                    gameController.food = gameController.food - 10;
                    Instantiate(building1, spawnPoint1.transform.position, Quaternion.identity);
                }
                else Debug.Log("Недостаточно ресурсов");

                break;

            case 2:
                if (gameController.wood >= 10)
                {
                    gameController.wood = gameController.wood - 10;
                    Instantiate(building2, spawnPoint2.transform.position, Quaternion.identity);
                }
                else Debug.Log("Недостаточно ресурсов");

                break;

            case 3:
                if (gameController.stone >= 10)
                {
                    gameController.stone = gameController.stone - 10;
                    Instantiate(building3, spawnPoint3.transform.position, Quaternion.identity);
                }
                else Debug.Log("Недостаточно ресурсов");

                break;

            case 4:
                if (gameController.iron >= 10)
                {
                    gameController.iron = gameController.iron - 10;
                    Instantiate(building4, spawnPoint4.transform.position, Quaternion.identity);
                }
                else Debug.Log("Недостаточно ресурсов");

                break;
        }
    }
}