using UnityEngine;

public class Tapioca : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Topping.Tapioca);
        displayDrink.UpdateHandT(Topping.Tapioca);
    }
}
