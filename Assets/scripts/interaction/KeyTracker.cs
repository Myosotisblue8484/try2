using System;
using UnityEngine;

public class KeyTracker : MonoBehaviour
{
    public int Keys;

    public int KeyAmount;
    
    public static KeyTracker Instance;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate
        }
    }
    
    public void Update()
    {
        KeyAmount = Keys;
        
        
    }
    
    
}
