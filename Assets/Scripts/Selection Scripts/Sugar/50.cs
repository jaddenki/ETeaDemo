using UnityEngine;

public class Fifty : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.SugarLevel.FiftyPercent);
        displayDrink.UpdateHandS(SugarLevel.FiftyPercent);
    }
}
