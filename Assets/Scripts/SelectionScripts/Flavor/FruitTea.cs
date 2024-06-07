using UnityEngine;

public class MatchaSelection : MonoBehaviour
{
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.UpdateSelection(PlayerInput.Flavor.FruitTea);
    }
}
