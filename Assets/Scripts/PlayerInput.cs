// user input of you going to the different stations
// Need to include how to select different stuff from stations
// need to include how to select which customer to serve at the end

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private int currentStation = 0;

    // placeholder selection options
    public enum Flavor { Taro, Matcha, FruitTea, Thai}
    public enum SugarLevel { ZeroPercent, TwentyFivePercent, FiftyPercent, OneHundredPercent }
    public enum Topping { Tapioca, Pudding, AloeVera, LycheeJelly }

    public Flavor selectedFlavor;
    public SugarLevel selectedSugar;
    public Topping selectedTopping;

    private object[] recentSelections = new object[4];

    // sprites for each station
    public Sprite startSprite;
    public Sprite flavorSprite;
    public Sprite space1Sprite;
    public Sprite iceSugarSprite;
    public Sprite space2Sprite;
    public Sprite toppingsSprite;

    private SpriteRenderer spriteRenderer;

    public GameObject flavorStationUI;
    public GameObject sugarLevelStationUI;
    public GameObject toppingsStationUI;

    void Start()
    {
        // sets initial sprite to the blank one
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = startSprite;
    }

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
        switch (currentStation)
        {
            case 0:
                Debug.Log("Flavor Station");
                // under here we want it to open the station UI and show 
                spriteRenderer.sprite = flavorSprite;
                flavorStationUI.SetActive(true);
                break;
            case 1:
                Debug.Log("Open Space 1");
                flavorStationUI.SetActive(false);
                sugarLevelStationUI.SetActive(false);
                spriteRenderer.sprite = space1Sprite;
                break;
            case 2:
                Debug.Log("Sugar Level Station");
                spriteRenderer.sprite = iceSugarSprite;
                sugarLevelStationUI.SetActive(true);
                break;
            case 3:
                Debug.Log("Open Space 2");
                sugarLevelStationUI.SetActive(false);
                toppingsStationUI.SetActive(false);
                spriteRenderer.sprite = space2Sprite;
                break;
            case 4:
                Debug.Log("Toppings Station");
                spriteRenderer.sprite = toppingsSprite;
                toppingsStationUI.SetActive(true);
                break;
            case 5:
                Debug.Log("Serve Babe");
                toppingsStationUI.SetActive(false);
                break;
        }
    }
    // update selection array
    public void UpdateSelection(object selection)
    {
        switch (currentStation)
        {
            case 0:
                recentSelections[0] = selection;
                break;
            case 2:
                recentSelections[1] = selection;
                break;
            case 4:
                recentSelections[2] = selection;
                break;
            case 5:
                recentSelections[3] = selection;
                break;
        }

        // print to debug log
        string selectionsLog = "Current Selections:\n";
        selectionsLog += "Flavor: " + recentSelections[0] + "\n";
        selectionsLog += "Ice Sugar Level: " + recentSelections[1] + "\n";
        selectionsLog += "Topping: " + recentSelections[2] + "\n";
        selectionsLog += "Customer Served: " + recentSelections[3];
        Debug.Log(selectionsLog);
    }
}
