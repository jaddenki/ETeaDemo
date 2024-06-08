using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDrink : MonoBehaviour
{
    public Sprite clear;
    public Sprite[] flavorImg;
    public SpriteRenderer flavorDisp;

    public Sprite[] sugarImg;
    public SpriteRenderer sugarDisp;

    public Sprite[] toppingImg;
    public SpriteRenderer toppingDisp;

    public void UpdateHandF(Flavor flavor)
    {
        flavorDisp.sprite = GetFlavorSprite(flavor);
    }

    public void UpdateHandS(SugarLevel sugar)
    {
        sugarDisp.sprite = GetSugarSprite(sugar);
    }

    public void UpdateHandT(Topping topping)
    {
        toppingDisp.sprite = GetToppingSprite(topping);
    }

    public void LetGo()
    {
        flavorDisp.sprite = clear;
        sugarDisp.sprite = clear;
        toppingDisp.sprite = clear;
    }

    private Sprite GetSugarSprite(SugarLevel sugar)
    {
        return sugarImg[(int)sugar];
    }
    private Sprite GetFlavorSprite(Flavor flavor)
    {
        return flavorImg[(int)flavor];
    }
    private Sprite GetToppingSprite(Topping topping)
    {
        return toppingImg[(int)topping];
    }
}
