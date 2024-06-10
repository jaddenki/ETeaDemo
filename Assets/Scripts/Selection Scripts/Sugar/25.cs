using UnityEngine;

public class TwentyFivePercent : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.SugarLevel.TwentyFivePercent);
        displayDrink.UpdateHandS(SugarLevel.TwentyFivePercent);
    }
}
