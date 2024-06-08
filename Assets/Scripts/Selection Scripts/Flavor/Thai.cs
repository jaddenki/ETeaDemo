using UnityEngine;

public class Thai : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(Flavor.Thai);
        displayDrink.UpdateHandF(Flavor.Thai);
    }
}
