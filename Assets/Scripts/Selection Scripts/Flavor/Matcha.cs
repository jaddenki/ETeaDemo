using UnityEngine;

public class Matcha : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Flavor.Matcha);
    }
}
