using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector3 startPos;

    public float speed = 3;
    public float xScale = 1;
    public float yScale = 1;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        //transform.position = startPos + (Vector3.right * Mathf.Sin(Time.timeSinceLevelLoad / 2 * speed) * xScale - Vector3.up * Mathf.Sin(Time.timeSinceLevelLoad * speed) * yScale);
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = startPos + new Vector3(0, -1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
    }


}
