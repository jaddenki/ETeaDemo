using System.Collections.Generic;
using UnityEngine;

public class QPCSugar : MonoBehaviour
{
    public Sprite[] sugarSprites; // array of sprites for different 
    public SpriteRenderer[] sugarDisplayRenderers; // each 

    //update the  displays based on current orders
    public void UpdateSugarDisplays(List<Order> orders)
    {
        // looj at all da sprite rendenres
        for (int i = 0; i < sugarDisplayRenderers.Length; i++)
        {
            if (i < orders.Count)
            {
                // cyurrent order
                Order currentOrder = orders[i];

                // update current rendrer with sprite
                sugarDisplayRenderers[i].sprite = GetSugarSprite(currentOrder.SugarChoice);
                sugarDisplayRenderers[i].gameObject.SetActive(true);
            }
            else
            {
                sugarDisplayRenderers[i].gameObject.SetActive(false);
            }
        }
    }

    //get the corresponding  sprite based on the  enum
    private Sprite GetSugarSprite(SugarLevel sugar)
    {
        return sugarSprites[(int)sugar];
    }
}
