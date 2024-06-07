using UnityEngine;

public class Fifty : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.SugarLevel.FiftyPercent);
    }
}
