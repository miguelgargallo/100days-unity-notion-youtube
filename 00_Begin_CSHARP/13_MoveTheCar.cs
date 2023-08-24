using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;

    void Start()
    {

    }

    void LateUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
