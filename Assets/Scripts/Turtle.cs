using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{

    private Vector3 MovingDirection = Vector3.left;    //initial movement direction
    private static System.Random random = new System.Random();
    private float val = RandomSpeed(random);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }

    void UpdateMovement()
    {

        

        if (this.transform.position.x > 24.0f)
        {
            MovingDirection = Vector3.left;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            val = RandomSpeed(random);
           // Debug.Log("Speed Change: " + val);

        }
        else if (this.transform.position.x < 9.0f)
        {
            MovingDirection = Vector3.right;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            val = RandomSpeed(random);
            //Debug.Log("Speed Change 2: " + val);
  
        }

        this.transform.Translate(MovingDirection * Time.smoothDeltaTime * val);

    }

    void OnTriggerEnter2D()
    {
        Debug.Log("OnTriggerEnter2D");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private static float RandomSpeed(System.Random random)
    {
        return (float)(random.NextDouble() * (5 - 1) + 1);

    }
}
