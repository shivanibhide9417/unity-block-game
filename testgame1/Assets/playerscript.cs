using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerscript : MonoBehaviour {
    public Rigidbody rb;
    public Text score;
	// Use this for initialization
	void Start () {
        //rb.AddForce(0, 200, 400);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, 1000*Time.deltaTime);
        score.text = rb.position.z.ToString("0");
        

       if(Input.GetKey("a"))
       { rb.AddForce(-100 * Time.deltaTime, 0, 0,ForceMode.VelocityChange); }

        if(Input.GetKey("d"))
        { rb.AddForce(100 * Time.deltaTime, 0, 0,ForceMode.VelocityChange); }
    }
}
