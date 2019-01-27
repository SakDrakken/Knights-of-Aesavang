using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D Player;

    float ver = .0f;
    float hor = .0f;
    bool isGrounded = false;

    [SerializeField]
    [Range(0f,100f)]
    private float moveSpeed = 10;

    [SerializeField]
    [Range(0f, 100f)]
    private float jumpForce = 5;

    void Start () {
        Player = GetComponent<Rigidbody2D>();
	}
	

	void FixedUpdate () {

        // get inputs
        ver = Input.GetAxis("Jump");
        hor = Input.GetAxis("Horizontal");

        // move player horizontally
        Player.AddForce(Vector2.right * hor * moveSpeed);

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // check for ground
        if (coll.transform.name == "Ground")
            isGrounded = true;
        else
            isGrounded = false;
        
    }
}
