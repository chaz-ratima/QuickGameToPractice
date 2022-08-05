using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public Rigidbody2D rb;
    public float moveSpeed = 3f;
    private bool interact;
    private bool nearDoor;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Get inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        interact = Input.GetKeyDown(KeyCode.Space);
    }

    private void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
    }
}
