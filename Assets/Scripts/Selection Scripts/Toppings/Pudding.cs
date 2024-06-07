using UnityEngine;

public class Pudding : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Topping.Pudding);
    }
}
