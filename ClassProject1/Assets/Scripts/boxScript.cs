using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS IS A CHANGE TO OBSERVE GITHUB PUSHING

public class boxScript : MonoBehaviour
{
    private int count;
    // Start is called before the first frame update
    void Start() // Like a constructor
    {
        count = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            count++;
            if(count == 3)
            {
                Destroy(this.gameObject);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}