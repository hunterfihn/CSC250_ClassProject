using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS IS A CHANGE TO OBSERVE GITHUB PUSHING

public class boxScript : MonoBehaviour
{
    public Vector3 goUp, goForward, goBack, goLeft, goRight;
    public float speed = 2.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() // Like a constructor
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;

        }
        else if (Input.GetKeyDown("b"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        else if (Input.GetKeyDown("w"))
        {
            rb.velocity = Vector3.forward * speed;

        }
        else if (Input.GetKeyDown("s"))
        {
            rb.velocity = Vector3.back * speed;

        }
        else if (Input.GetKeyDown("a"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("d"))
        {
            rb.velocity = Vector3.right * speed;
        }

    }
}