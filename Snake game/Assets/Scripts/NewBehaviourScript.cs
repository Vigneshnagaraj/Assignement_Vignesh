using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    Rigidbody rb;
    

    public float speed = 0;
    private void Awake()
    {
        rb= GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, speed);

    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            moveright();
        }
        else if ((Input.GetMouseButtonDown(1)))
        {
            moveleft();
        }
    }


    void moveright()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }
    void moveleft()
    {
        rb.velocity = new Vector3(speed, 0, 0);

    }

    
}




