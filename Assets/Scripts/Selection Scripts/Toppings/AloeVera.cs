using UnityEngine;

public class AloeVera : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;


    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.Topping.AloeVera);
        displayDrink.UpdateHandT(Topping.AloeVera);
    }
}
