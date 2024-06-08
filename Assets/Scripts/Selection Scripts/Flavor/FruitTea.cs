using UnityEngine;

public class FruitTea : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Flavor.FruitTea);
        displayDrink.UpdateHandF(Flavor.FruitTea);
    }
}
