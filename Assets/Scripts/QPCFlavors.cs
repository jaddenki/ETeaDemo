using System.Collections.Generic;
using UnityEngine;

public class QPCFlavors : MonoBehaviour
{
    public Sprite[] flavorSprites; // array of sprites for different 
    public SpriteRenderer[] flavorDisplayRenderers; // each 

   //update the  displays based on current orders
    public void UpdateFlavorDisplays(List<Order> orders)
    {
        // looj at all da sprite rendenres
        for (int i = 0; i < flavorDisplayRenderers.Length; i++)
        {
            if (i < orders.Count)
            {
                // cyurrent order
                Order currentOrder = orders[i];

                // update current rendrer with sprite
                flavorDisplayRenderers[i].sprite = GetFlavorSprite(currentOrder.FlavorChoice);
                flavorDisplayRenderers[i].gameObject.SetActive(true);
            }
            else
            {
                flavorDisplayRenderers[i].gameObject.SetActive(false);
            }
        }
    }

    //get the corresponding  sprite based on the  enum
    private Sprite GetFlavorSprite(Flavor flavor)
    {
        return flavorSprites[(int)flavor];
    }
}
