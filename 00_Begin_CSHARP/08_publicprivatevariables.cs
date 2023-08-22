using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheCar : MonoBehaviour
{
    public float speed = 5.0f;

    private void Start()
    {

    }

    void Update()
    {
        /* transform.Translate(0, 0, 1); */
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
