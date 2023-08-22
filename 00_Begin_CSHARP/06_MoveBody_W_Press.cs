using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheCar : MonoBehaviour
{
    public float speed = 5.0f; // Speed at which the car moves

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
