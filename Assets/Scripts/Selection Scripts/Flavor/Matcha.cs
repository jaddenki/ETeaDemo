using UnityEngine;

public class Matcha : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.Flavor.Matcha);
        displayDrink.UpdateHandF(Flavor.Matcha);
    }
}
