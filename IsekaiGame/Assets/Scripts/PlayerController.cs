using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public Rigidbody2D rb;
    public float moveSpeed = 3f;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Get inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
    }
}
