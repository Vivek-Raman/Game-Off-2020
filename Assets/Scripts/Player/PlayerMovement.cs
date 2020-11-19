using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField][Range(0f, 10f)] private float movementSpeed = 4f;
    [SerializeField][Range(0f, 10f)] private float jumpSpeed = 8f;
    [SerializeField][Range(-5f, 0f)] private float gravity = -10f;
    
    [SerializeField][Range(0f, 1f)] private float airControlModifier = 0.8f;

    private Rigidbody2D rb = null;

    private Vector2 velocity = Vector2.zero;
    private float inputX = 0f;
    private bool jumpIsBuffered = false;

    private bool IsAirborne => !Physics2D.OverlapCircle(this.transform.position, 0.04f, 1 << 8);

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        if (!jumpIsBuffered)
        {
            jumpIsBuffered = Input.GetButtonDown("Jump");
        }
    }

    private void FixedUpdate()
    {
        velocity.x = movementSpeed * inputX;

        // air control & gravity
        if (IsAirborne)
        {
             velocity.x *= airControlModifier;
             velocity.y += gravity;
        }
        // jump if buffered
        else if (jumpIsBuffered)
        {
            velocity.y = jumpSpeed;
            jumpIsBuffered = false;
        }

        rb.velocity = Vector2.Lerp(rb.velocity, velocity, 0.8f);
    }
}
