using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour {
    public float speed;
    public float jump;
    public Vector3 spawn;
    private Rigidbody rb;
    private Rigidbody jp;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawn = transform.position;        
    }
    void FixedUpdate()
    {
     
        
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity = -transform.right * speed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity = transform.right * speed;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = transform.up * jump;
        }
    }
}
