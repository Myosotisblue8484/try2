using UnityEngine;

public class Indicator_Spinner : MonoBehaviour
{
    public float SpinSpeed = 5;
    public Vector3 SpinAxis;
    
    void Awake()
    {
        
    }

    void Update()
    {
        transform.Rotate(SpinAxis * SpinSpeed * Time.deltaTime);
    }
}
