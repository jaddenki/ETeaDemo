using UnityEngine;

public class Matcha : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;
    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Flavor.Matcha);
        displayDrink.UpdateHandF(Flavor.Matcha);
    }
}
