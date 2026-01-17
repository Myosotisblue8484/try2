using System;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            KeyTracker.Instance.Keys++;
            
            Destroy(other.gameObject);
        }
    }
}
