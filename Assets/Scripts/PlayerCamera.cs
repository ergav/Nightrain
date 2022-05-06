using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerCamera : MonoBehaviour
{
    Vector2 rotation = new Vector2(0, 0);
    [Range( 1, 100)]public float mouseSensitivity = 100;
    public Transform playerBody;
    public float verticalRotation;
    InputManager inputManager;
    [SerializeField] float clampedAngle = 80;

    Vector2 deltaRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inputManager = InputManager.Instance;
        if (playerBody == null)
        {
            playerBody = GetComponentInParent<Transform>();
        }
        verticalRotation = 0;

    }

    void Update()
    {
        Vector2 deltaRotation = inputManager.GetMouseDelta();


        verticalRotation += -deltaRotation.y * mouseSensitivity * Time.deltaTime;
        verticalRotation = Mathf.Clamp(verticalRotation, -clampedAngle, clampedAngle);

        rotation.x = verticalRotation;
        transform.localEulerAngles = (Vector2)rotation;
        playerBody.Rotate(new Vector3(0, deltaRotation.x * mouseSensitivity * Time.deltaTime, 0));
    }
}
