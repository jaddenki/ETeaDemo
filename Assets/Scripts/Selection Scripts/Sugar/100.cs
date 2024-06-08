using UnityEngine;

public class OneHundred : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.SugarLevel.OneHundredPercent);
        displayDrink.UpdateHandS(SugarLevel.OneHundredPercent);
    }
}
