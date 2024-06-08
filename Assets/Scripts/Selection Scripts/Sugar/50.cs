using UnityEngine;

public class Fifty : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.SugarLevel.FiftyPercent);
        displayDrink.UpdateHandS(SugarLevel.FiftyPercent);
    }
}
