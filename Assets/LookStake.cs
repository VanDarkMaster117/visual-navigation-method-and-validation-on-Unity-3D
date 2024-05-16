using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookStake : MonoBehaviour
{
    public float RYSpeed = 200;
    public float RXSpeed = 200;
    public float ScrollSpeed = 100;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float h = Input.GetAxis("Mouse X");
            float v = Input.GetAxis("Mouse Y");
            transform.Rotate(v * RXSpeed * Time.deltaTime, h * RYSpeed * Time.deltaTime, 0);
        }
        float value = Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(0, 0, -value * Time.deltaTime * ScrollSpeed);
    }
}
