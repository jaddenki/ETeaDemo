using UnityEngine;

public class TwentyFivePercent : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;
    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.SugarLevel.TwentyFivePercent);
        displayDrink.UpdateHandS(SugarLevel.TwentyFivePercent);
    }
}
