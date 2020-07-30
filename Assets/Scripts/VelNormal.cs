using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelNormal : MonoBehaviour
{
     public PowerUp powerUpScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            powerUpScript.VelNormal(); 
        }
    }
}
