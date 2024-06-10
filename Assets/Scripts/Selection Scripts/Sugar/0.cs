using UnityEngine;

public class ZeroPercent : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(PlayerInput.SugarLevel.ZeroPercent);
        displayDrink.UpdateHandS(SugarLevel.ZeroPercent);
    }
}
