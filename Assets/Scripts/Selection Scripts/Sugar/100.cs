using UnityEngine;

public class OneHundred : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.SugarLevel.OneHundredPercent);
        displayDrink.UpdateHandS(SugarLevel.OneHundredPercent);
    }
}
