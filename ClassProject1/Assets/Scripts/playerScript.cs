using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Vector3 goUp, goForward, goBack, goLeft, goRight;
    public float speed = 5.0f;
    private Rigidbody rb;
    private Player thePlayer;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = new Player("Hunter");
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            count++;
            if(count == 3)
            {
                this.thePlayer.addKill();
                print("Kill count is: " + this.thePlayer.getKillCount());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;

        }
        else if (Input.GetKey("b"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        else if (Input.GetKey("w"))
        {
            rb.velocity = Vector3.forward * speed;

        }
        else if (Input.GetKey("s"))
        {
            rb.velocity = Vector3.back * speed;

        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKey("d"))
        {
            rb.velocity = Vector3.right * speed;
        }
    }
}
