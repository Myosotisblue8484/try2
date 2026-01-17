using System;
using UnityEngine;

public class KeyTrackerStatic : MonoBehaviour
{

    public GameObject Door_Teen;
    public GameObject Door_Adult; 
    
    
    private void FixedUpdate()
    {
        OpenDoors();
    }

    private void OpenDoors()
    {
        if (KeyTracker.Instance == null) return;
        
        if (KeyTracker.Instance.KeyAmount >= 1)
        {
            Door_Teen.SetActive(true);
        }

        if (KeyTracker.Instance.KeyAmount >= 2)
        {
            Door_Adult.SetActive(true);
            Door_Teen.SetActive(true);
        }
    }
}
