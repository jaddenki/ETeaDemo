using UnityEngine;
public class CustomerSelection : MonoBehaviour
{
    public int customerIndex;
    public PlayerInput playerInput;

    private void OnMouseDown()
    {
        playerInput.ServeOrder(customerIndex);
    } 
}
