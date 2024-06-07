using UnityEngine;

public class FruitTea : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Flavor.FruitTea);
    }
}
