using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInteractions : MonoBehaviour
{
    public InputActionAsset interactActions;
    private InputActionMap _actionMap;
    
    public float interactDistance = 3f;
    public Camera playerCamera;

    
    void OnEnable()
    {
        interactActions.Enable();
    }

    void OnDisable()
    {
        interactActions.Disable();
    }

    void Awake()
    {
        _actionMap = interactActions.FindActionMap("Player", true);
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
            ShootRay();
    }
    
    void ShootRay()
    {
        if (playerCamera == null)
        {
            Debug.LogWarning("Player camera not set");
            return;
        }
        
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            Debug.Log("Help");
        }
    }
}
