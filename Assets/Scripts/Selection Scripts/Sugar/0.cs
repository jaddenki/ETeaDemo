using UnityEngine;

public class ZeroPercent : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.SugarLevel.ZeroPercent);
    }
}
