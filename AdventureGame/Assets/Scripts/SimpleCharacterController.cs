using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    [SerializeField] bool grounded;
    
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 velocity;
    
    private void Start()
    {
        // Cache references to components
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        KeepCharacterOnXAxis();
        ExtraGroundingCheck();
        ApplyGravity();
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        // Horizontal movement
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);

        // Jumping
        if (Input.GetButtonDown("Jump") && grounded)
        { 
            Debug.Log("Jump");
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            grounded = false;
            Debug.Log("Ungrounded (jump)");
        }
    }
    
    void ApplyGravity()
    {
        // Apply gravity when not grounded
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            // Keep pushing slightly to ensure grounding
            velocity.y += (gravity / 100) * Time.deltaTime;
            Debug.Log("I'm grounded!");
            grounded = true;
            // velocity.y = 0f;
        }
        
        // Apply the velocity to the controller
        controller.Move(velocity * Time.deltaTime);
    }

    void ExtraGroundingCheck()
    {
        if (!controller.isGrounded)
        {
            Debug.Log("Ungrounded (extra check)");
            velocity.y += (gravity / 100) * Time.deltaTime;
            if (controller.isGrounded)
            {
                grounded = true;
                Debug.Log("Grounded (extra check)");
            }
        }
        
        if (controller.isGrounded && grounded == false)
        {
            grounded = true;
            Debug.Log("Grounded (missed check)");
        }
    }
    
    private void KeepCharacterOnXAxis()
    {
        // Use cached transform reference and optimize vector creation
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
