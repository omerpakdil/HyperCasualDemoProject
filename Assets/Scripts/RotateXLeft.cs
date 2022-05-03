using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateXLeft : MonoBehaviour
{

    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0, Space.Self);
    }
}
