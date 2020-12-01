using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateResource : MonoBehaviour
{
    public Text wood;
    public Text food;
    public Text stone;
    public Text iron;
    public Text money;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        wood.text = ResourcesController.wood.ToString();
        food.text = ResourcesController.food.ToString();
        stone.text = ResourcesController.stone.ToString();
        iron.text = ResourcesController.iron.ToString();

    }
}