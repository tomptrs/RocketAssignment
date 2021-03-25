using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovmet : MonoBehaviour
{
    public Rigidbody rb;
    public float power = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 0.5f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -0.5f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Accelerate();
        }
    }

    private void Accelerate()
    {
        //Apply a force to this Rigidbody in direction of this GameObjects up axis
        rb.AddForce(transform.up * power, ForceMode.Acceleration);
    }
}
