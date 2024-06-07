// this will be a script to manage the queue of orders
// view list of orders ?

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderQueue : MonoBehaviour
{
    public List<Order> ordersQueue = new List<Order>();
    public int maxOrders = 4;
    public float orderInterval = 5f; // 20 seconds?!?!?!?
    private int orderNumber = 0;

    void Start()
    {
        Debug.Log("Gimme an Order");
        StartCoroutine(AddOrdersAtIntervals());
    }

    private IEnumerator AddOrdersAtIntervals()
    {
        Debug.Log("HAI");
        while (true) // infinite loop for continuous order generation
        {
            if (orderNumber < maxOrders)
            {
                AddRandomOrder();
                Debug.Log("New Order Added. Total Orders: " + ordersQueue.Count);
                Debug.Log("i'm here");
            }
            else
            {
                Debug.Log("ququ full");
            }
           yield return new WaitForSeconds(orderInterval);
        }
    }


    void DisplayOrders()
    {
        Debug.Log("Orders:");
        foreach (Order order in ordersQueue)
        {
            Debug.Log(order);
        }
    }

    public Order GetCurrentOrder()
    {
        if (ordersQueue.Count > 0)
        {
            return ordersQueue[0]; // first order
        }
        return null; // none!
    }

    // heheheh
    public void ServeCurrentOrder()
    {
        if (ordersQueue.Count > 0)
        {
            ordersQueue.RemoveAt(0); // remove first order form list
            orderNumber--;
        }
    }

    // new order

        public void AddRandomOrder()
        {

            Order newOrder = Order.GenerateRandomOrder();
            ordersQueue.Add(newOrder);
            orderNumber++;

            Debug.Log("Added new order: " + newOrder);
            DisplayOrders();
        }
}
