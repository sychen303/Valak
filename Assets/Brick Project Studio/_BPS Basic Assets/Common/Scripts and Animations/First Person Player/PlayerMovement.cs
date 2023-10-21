using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SojaExiles
{
    public class PlayerMovement : MonoBehaviour
    {
        public CharacterController controller;
        public float speed = 5.0f;
        public float sprintSpeed = 15.0f;
        public float gravity = -20.0f;
        public float jumpHeight = 2.0f;
        public float sprintDuration = 3.0f;
        public float sprintCooldown = 7.0f;

        Vector3 velocity;
        bool isGrounded;
        bool jump;
        bool isSprinting = false;
        float sprintTimer = 0f;
        float cooldownTimer = 0f;

        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            if (Input.GetKeyDown(KeyCode.Backspace)){
                Application.Quit();
            }
            if (controller.isGrounded)
            {
                velocity.y = 0;
            }
            if (Input.GetKeyDown(KeyCode.Space)&&controller.isGrounded)
            {
                float jumpVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
                velocity.y = jumpVelocity;
            }

            // Check for sprint input
            if (Input.GetKey(KeyCode.LeftShift) && !isSprinting && cooldownTimer <= 0)
            {
                StartSprint();
            }

            if (isSprinting)
            {
                // Update the sprint timer
                sprintTimer -= Time.deltaTime;

                if (sprintTimer <= 0)
                {
                    StopSprint();
                }
            }
            else if (cooldownTimer > 0)
            {
                // Update the cooldown timer
                cooldownTimer -= Time.deltaTime;
            }

            // Update the player's speed
            float currentSpeed = isSprinting ? sprintSpeed : speed;

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * currentSpeed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }

        void StartSprint()
        {
            isSprinting = true;
            sprintTimer = sprintDuration;
        }

        void StopSprint()
        {
            isSprinting = false;
            cooldownTimer = sprintCooldown;
        }
    }
}