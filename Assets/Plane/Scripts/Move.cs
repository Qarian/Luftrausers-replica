using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour {

    Rigidbody2D rb;
    public float speed, rspeed;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    private void Update()
    {
        transform.Rotate( 0f, 0f, Input.GetAxis( "Horizontal" )*rspeed );
    }

    void FixedUpdate () {
        if( Input.GetButton( "Forward" ) )
        {
            rb.AddForce( transform.up*speed );
        }
    }
}