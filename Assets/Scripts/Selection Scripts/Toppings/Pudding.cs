using UnityEngine;

public class Pudding : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.Topping.Pudding);
        displayDrink.UpdateHandT(Topping.Pudding);
    }
}
