using UnityEngine;

public class AloeVera : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Topping.AloeVera);
    }
}
