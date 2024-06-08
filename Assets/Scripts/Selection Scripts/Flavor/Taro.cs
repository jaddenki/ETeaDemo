using UnityEngine;

public class Taro : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(Flavor.Taro);
        displayDrink.UpdateHandF(Flavor.Taro);
    }
}
