using UnityEngine;

public class Tapioca : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Topping.Tapioca);
    }
}
