using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float minLimitRotation = 60;
    [SerializeField] private float maxLimitRotation = 60;
    [SerializeField] private float speed = 10f;

    private float startYRotation;

    void Start()
    {
        startYRotation = transform.localEulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        float minRotation = startYRotation - minLimitRotation;
        float maxRotation = startYRotation + maxLimitRotation;

        float currentYRotation = transform.localEulerAngles.y;
        currentYRotation = (currentYRotation > 180) ? currentYRotation - 360 : currentYRotation;

        if(currentYRotation < minRotation || currentYRotation > maxRotation)
        {
            speed = -speed;
        }

        Vector3 rotationEuler = transform.InverseTransformDirection(Vector3.up) * speed * Time.deltaTime;

        transform.rotation = transform.rotation * Quaternion.Euler(rotationEuler);
        //transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.World);
    }
}
