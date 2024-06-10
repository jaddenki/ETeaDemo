using UnityEngine;

public class LycheeJelly : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;


    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.Topping.LycheeJelly);
        displayDrink.UpdateHandT(Topping.LycheeJelly);
    }
}
