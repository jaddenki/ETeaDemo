using UnityEngine;
public class CustomerSelection : MonoBehaviour
{
    public int customerIndex;
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        int lol = (customerIndex % 2);
        playerInput.ServeOrder(lol);
    } 
}
