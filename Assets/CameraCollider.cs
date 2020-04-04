using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag("Player")) return;

        Debug.Log("Player detected!");
    }

    void OnTriggerExit(Collider collider)
    {
        if (!collider.CompareTag("Player")) return;

        Debug.Log("Player escaped!");
    }
}
