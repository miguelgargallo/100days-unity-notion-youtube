using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheCar : MonoBehaviour
{

    private void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, 0, 1);
    }
}
