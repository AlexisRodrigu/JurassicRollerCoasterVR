using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelNormal : MonoBehaviour
{
     public PowerUp pw;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pw.VelNormal();
            Debug.Log("Ruduces");
        }
    }
}
