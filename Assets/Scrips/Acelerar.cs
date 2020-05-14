using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerar : MonoBehaviour
{
    public PowerUp pw;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pw.Acelerar();
            Debug.Log("Aceleras");
        }
    }
}
