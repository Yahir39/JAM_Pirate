using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float moveSpeed = 5f;
    float xVelocity, yVelocity;

    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        xVelocity = Input.GetAxis("Horizontal") * moveSpeed;
        yVelocity = Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector2(xVelocity, yVelocity);    

    }
}
