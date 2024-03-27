using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    private Vector3 startPos;

    public float speed = 2;
    public float xScale = 1;
    public float yScale = 1;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // transform.position = startPos + (Vector3.right * Mathf.Sin(Time.timeSinceLevelLoad / 2 * speed) * xScale - Vector3.up * Mathf.Sin(Time.timeSinceLevelLoad * speed) * yScale);
    }

    void FixedUpdate()
    {
        this.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        this.transform.Translate(0, Input.GetAxis("Vertical") * Time.deltaTime, 0);
    }
}
