using UnityEngine;

public class Thai : MonoBehaviour
{
    public PlayerInput playerInput;
    public DisplayDrink displayDrink;

    public AudioSource select;

    private void OnMouseDown()
    {
        select.Play();
        playerInput.UpdateSelection(Flavor.Thai);
        displayDrink.UpdateHandF(Flavor.Thai);
    }
}
