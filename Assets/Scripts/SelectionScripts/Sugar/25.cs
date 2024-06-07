using UnityEngine;

public class TwentyFivePercent : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.SugarLevel.TwentyFivePercent);
    }
}
