using UnityEngine;
using UnityEngine.InputSystem;

public class Footsteps : MonoBehaviour
{
    public GameObject footstepSound;

    void Awake()
    {
    }
    
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            footstepSound.SetActive(true);
        }
        else
        {
            footstepSound.SetActive(false);
        }
    }
}
