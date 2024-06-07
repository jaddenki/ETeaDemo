using UnityEngine;

public class OneHundred : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.SugarLevel.OneHundredPercent);
    }
}
