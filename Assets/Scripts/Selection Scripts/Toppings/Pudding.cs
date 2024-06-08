using UnityEngine;

public class Pudding : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Topping.Pudding);
        displayDrink.UpdateHandT(Topping.Pudding);
    }
}
