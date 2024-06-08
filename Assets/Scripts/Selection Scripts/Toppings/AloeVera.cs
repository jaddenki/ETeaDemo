using UnityEngine;

public class AloeVera : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Topping.AloeVera);
        displayDrink.UpdateHandT(Topping.AloeVera);
    }
}
