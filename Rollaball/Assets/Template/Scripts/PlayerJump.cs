using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    private float jumpSpeed = 5;
    private Rigidbody rb;
    private bool onGround = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && onGround) {
	    rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
	    onGround = false;
	}
    }

    void OnCollisionEnter(Collision collision) {
	onGround = true;
    }
}
