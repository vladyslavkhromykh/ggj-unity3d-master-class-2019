using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReadyToUse
{
    public class PlayerMovement : MonoBehaviour
    {
        public Transform Camera;
        [Range(1.0f, 10.0f)]
        public float ForwardMovementSpeed;
        [Range(1.0f, 20.0f)]
        public float SideMovementSpeed;
        [Range(1.0f, 10.0f)]
        public float LookSpeed;

        private Vector2 rotation = Vector2.zero;

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            float forwardMovement = Input.GetAxis("Vertical");
            float sideMovement = Input.GetAxis("Horizontal");
            transform.Translate(sideMovement * SideMovementSpeed * Time.deltaTime, 0.0f, forwardMovement * ForwardMovementSpeed * Time.deltaTime);

            rotation.x += -Input.GetAxis("Mouse Y");
            rotation.x = Mathf.Clamp(rotation.x, -15f, 15f);
            rotation.y = Input.GetAxis("Mouse X");
            Camera.localRotation = Quaternion.Euler(rotation.x * LookSpeed, 0.0f, 0.0f);
            transform.Rotate(0.0f, rotation.y * LookSpeed, 0.0f);
        }
    }

}
