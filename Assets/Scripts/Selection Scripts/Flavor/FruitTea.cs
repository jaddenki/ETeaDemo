using UnityEngine;

public class FruitTea : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.Flavor.FruitTea);
        displayDrink.UpdateHandF(Flavor.FruitTea);
    }
}
