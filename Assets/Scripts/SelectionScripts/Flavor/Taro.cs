using UnityEngine;

public class Taro : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Flavor.Taro);
    }
}
