using UnityEngine;

public class LycheeJelly : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Topping.LycheeJelly);
        displayDrink.UpdateHandT(Topping.LycheeJelly);
    }
}
