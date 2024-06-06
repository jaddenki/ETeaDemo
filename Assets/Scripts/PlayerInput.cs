// user input of you going to the different stations
// Need to include how to select different stuff from stations
// need to include how to select which customer to serve at the end

using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private int currentStation = 0;
    public Flavor selectedFlavor;
    public SugarLevel selectedSugar;
    public Topping selectedTopping;


    void Update()
    {

        // when u wanna switch stations
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentStation > 0)
            {
                currentStation--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentStation < 5)
            {
                currentStation++;
            }
        }

        // selecting stuff at their stations
        switch(currentStation)
        {
            case 0:
                Debug.Log("Flavor Station");
                // under here we want it to open the station UI and show the choices
                break;
            case 1:
                Debug.Log("Open Space 1");
                break;
            case 2:
                Debug.Log("Sugar Level Station");
                break;
            case 3:
                Debug.Log("Open Space 2");
                break;
            case 4:
                Debug.Log("Toppings Station");
                break;
            case 5:
                Debug.Log("Serve Babe");
                break;
        }

    }
}
