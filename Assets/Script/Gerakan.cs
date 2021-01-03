using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerakan : MonoBehaviour {
    Rigidbody rb;
    float jeda = 0f;
    public float forward = 4000f;
    public float side = 100f;
    public float jump = 80000f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forward * Time.deltaTime);
        jeda -= Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if(jeda < 0f) { 
                rb.AddForce(0, jump * Time.deltaTime, 0);
                jeda = 1.5f;
            }

        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<MyGameManager>().EndGame();
        }
    }
}
