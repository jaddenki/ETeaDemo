using System.Collections.Generic;
using UnityEngine;

public class QPCToppings : MonoBehaviour
{
    public Sprite[] toppingSprites; // Array of sprites for different toppings
    public SpriteRenderer[] toppingDisplayRenderers; // Array of SpriteRenderers for each QPC's topping display

    // Method to update the topping displays based on current orders
    public void UpdateToppingDisplays(List<Order> orders)
    {
        // Iterate over the QPC's SpriteRenderers
        for (int i = 0; i < toppingDisplayRenderers.Length; i++)
        {
            if (i < orders.Count)
            {
                // Get the current order
                Order currentOrder = orders[i];

                // Update the corresponding SpriteRenderer with the topping sprite
                toppingDisplayRenderers[i].sprite = GetToppingSprite(currentOrder.ToppingChoice);
                toppingDisplayRenderers[i].gameObject.SetActive(true); // Ensure the display is active
            }
            else
            {
                // Hide the SpriteRenderer if there's no corresponding order
                toppingDisplayRenderers[i].gameObject.SetActive(false);
            }
        }
    }

    // Method to get the corresponding topping sprite based on the topping enum
    private Sprite GetToppingSprite(Topping topping)
    {
        return toppingSprites[(int)topping];
    }
}
