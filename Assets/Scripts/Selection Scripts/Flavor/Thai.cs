using UnityEngine;

public class Thai : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Flavor.Thai);
    }
}
