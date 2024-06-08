using System.Collections.Generic;
using UnityEngine;

public class QPCToppings : MonoBehaviour
{
    public Sprite[] toppingSprites; 
    public SpriteRenderer[] toppingDisplayRenderers; 


    public void UpdateToppingDisplays(List<Order> orders)
    {

        for (int i = 0; i < toppingDisplayRenderers.Length; i++)
        {
            if (i < orders.Count)
            {
  
                Order currentOrder = orders[i];


                toppingDisplayRenderers[i].sprite = GetToppingSprite(currentOrder.ToppingChoice);
                toppingDisplayRenderers[i].gameObject.SetActive(true);
            }
            else
            {

                toppingDisplayRenderers[i].gameObject.SetActive(false);
            }
        }
    }


    private Sprite GetToppingSprite(Topping topping)
    {
        return toppingSprites[(int)topping];
    }
}
