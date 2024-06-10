using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToppings : MonoBehaviour
{

    public Sprite[] toppingSprites;
    private SpriteRenderer toppSprite;


    public void UpdateToppingDisplays(List<Order> orders)
    {
        toppSprite = GetComponent<SpriteRenderer>();

        for (int i = 0; i < 2; i++)
        {
            if (i < orders.Count)
            {

                //GameObject qpc = qpcImages[i];
                Order currentOrder = orders[i];

    
                //qpc.SetActive(true);

                toppSprite.sprite = GetToppingSprite(currentOrder.ToppingChoice);
            }
            else
            {

                Debug.Log("bruh");//qpcImages[i].SetActive(false);
            }
        }
    }

    private Sprite GetToppingSprite(Topping topping)
    {
        return toppingSprites[(int)topping];
    }
}