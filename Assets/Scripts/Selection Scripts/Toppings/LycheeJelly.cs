using UnityEngine;

public class LycheeJelly : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Topping.LycheeJelly);
    }
}
