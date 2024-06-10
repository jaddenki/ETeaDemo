using UnityEngine;

public class Taro : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(Flavor.Taro);
        displayDrink.UpdateHandF(Flavor.Taro);
    }
}
