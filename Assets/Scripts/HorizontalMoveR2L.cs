using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMoveR2L : MonoBehaviour
{

    private Vector3 pos1;
    private Vector3 pos2;
    public float speed = 2f;

    void Start()
    {
        Vector3 diff = new Vector3(-7, 0, 0);
        pos1 = transform.position;
        pos2 = transform.position + diff;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1f));
    }
}
