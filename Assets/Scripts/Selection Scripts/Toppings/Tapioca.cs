using UnityEngine;

public class Tapioca : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.Topping.Tapioca);
        displayDrink.UpdateHandT(Topping.Tapioca);
    }
}
