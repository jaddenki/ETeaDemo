// user input of you going to the different stations
// Need to include how to select different stuff from stations
// need to include how to select which customer to serve at the end

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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

    private object[] recentSelections = new object[3];
    private object[] currentOrderArray = new object[3]; // customer order

    // sprites for each station
    public Sprite startSprite;
    public Sprite flavorSprite;
    public Sprite space1Sprite;
    public Sprite iceSugarSprite;
    public Sprite space2Sprite;
    public Sprite toppingsSprite;
    public Sprite trynaServeSprite;

    private SpriteRenderer spriteRenderer;

    public GameObject flavorStationUI;
    public GameObject sugarLevelStationUI;
    public GameObject toppingsStationUI;
    public GameObject Qpc1;
    public GameObject Qpc2;
    public GameObject Qpc3;
    public GameObject Qpc4;

    public OrderQueue orderQueue;

    // for the delay!!!
    private float inputDelay = 0.2f;  // how long u want
    private float lastInputTime = 0f;



    void Start()
    {
        // sets initial sprite to the blank one
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = startSprite;

        // order queue
        if (orderQueue == null)
        {
            orderQueue = FindObjectOfType<OrderQueue>();
        }
        orderQueue.AddRandomOrder(); // add order
    }



    void Update()
    {
        // when u wanna switch stations
        if (Time.time - lastInputTime >= inputDelay) // did enough time pass ?!?!
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (currentStation > 0)
                {
                    currentStation--;
                    lastInputTime = Time.time;
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (currentStation < 5)
                {
                    currentStation++;
                    lastInputTime = Time.time;
                }
            }
        }

            // selecting stuff at their stations
            switch (currentStation)
        {
            case 0:
               // Debug.Log("Flavor Station");
                // under here we want it to open the station UI and show 
                spriteRenderer.sprite = flavorSprite;
                flavorStationUI.SetActive(true);
                break;
            case 1:
               // Debug.Log("Open Space 1");
                flavorStationUI.SetActive(false);
                sugarLevelStationUI.SetActive(false);
                spriteRenderer.sprite = space1Sprite;
                break;
            case 2:
               // Debug.Log("Sugar Level Station");
                spriteRenderer.sprite = iceSugarSprite;
                sugarLevelStationUI.SetActive(true);
                break;
            case 3:
               // Debug.Log("Open Space 2");
                sugarLevelStationUI.SetActive(false);
                toppingsStationUI.SetActive(false);
                spriteRenderer.sprite = space2Sprite;
                break;
            case 4:
                // Debug.Log("Toppings Station");
                Qpc1.SetActive(false);
                Qpc2.SetActive(false);
                Qpc3.SetActive(false);
                Qpc4.SetActive(false);
                spriteRenderer.sprite = toppingsSprite;
                toppingsStationUI.SetActive(true);
                break;
            case 5:
               // Debug.Log("Serve Babe");
                toppingsStationUI.SetActive(false);
                Qpc1.SetActive(true);
                Qpc2.SetActive(true);
                Qpc3.SetActive(true);
                Qpc4.SetActive(true);
                spriteRenderer.sprite = trynaServeSprite;
                break;
        }
    }

    public void ServeOrder(int customerIndex)
    {
        try
        {
            Debug.Log("Now serving customer: " + customerIndex);

            Order currentOrder = orderQueue.ordersQueue[customerIndex - 1];
            Debug.Log("current order " + currentOrder.ToString());
            if (currentOrder != null)
            {

                currentOrderArray[0] = currentOrder.FlavorChoice;
                currentOrderArray[1] = currentOrder.SugarChoice;
                currentOrderArray[2] = currentOrder.ToppingChoice;

                if (CheckOrderMatch(currentOrder))
                {
                    Debug.Log("slayed!");
                    orderQueue.ServeCurrentOrder();
                }
                else
                {
                    Debug.Log("WRONGGGGGG.");
                }
            }
            else
            {
                Debug.Log("none");
            }
        }
        catch (NullReferenceException ex) // in case they try to submit with an item not selected
        {
            Debug.Log("WRONGGGGGG. loser");
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
        }

        // print to debug log
        string selectionsLog = "Flavor: " + recentSelections[0];
        selectionsLog += ", Ice Sugar Level: " + recentSelections[1];
        selectionsLog += ", Topping: " + recentSelections[2];
        Debug.Log(selectionsLog);
        }
    private bool CheckOrderMatch(object currentOrder)
    {
       
        for (int i = 0; i < recentSelections.Length; i++)
        {
            Debug.Log($"{recentSelections[i]} x {currentOrderArray[i]}");
            if (recentSelections[i].ToString() != currentOrderArray[i].ToString())
            {
                return false;
            }
        }
        return true;
    }
}
