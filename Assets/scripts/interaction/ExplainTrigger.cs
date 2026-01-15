using System;
using UnityEngine;

public class ExplainTrigger : MonoBehaviour
{
    public GameObject explain;
    

    private void OnTriggerEnter(Collider other)
    {
        explain.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        explain.SetActive(false);
    }
}
