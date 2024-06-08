using UnityEngine;

public class ZeroPercent : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.SugarLevel.ZeroPercent);
        displayDrink.UpdateHandS(SugarLevel.ZeroPercent);
    }
}
