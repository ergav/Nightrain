using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerCamera : MonoBehaviour
{
    Vector2 rotation = new Vector2(0, 0);
    public float speed = 100;
    public Transform playerBody;
    float verticalRotation;
    InputManager inputManager;
    [SerializeField] float clampedAngle = 80;

    void Start()
    {
        inputManager = InputManager.Instance;
        if (playerBody == null)
        {
            playerBody = GetComponentInParent<Transform>();
        }
    }

    void Update()
    {
        Vector2 deltaRotation = inputManager.GetMouseDelta();


        verticalRotation += -deltaRotation.y * speed * Time.deltaTime;
        verticalRotation = Mathf.Clamp(verticalRotation, -clampedAngle, clampedAngle);

        rotation.x = verticalRotation;
        transform.localEulerAngles = (Vector2)rotation;
        playerBody.Rotate(new Vector3(0, deltaRotation.x * speed * Time.deltaTime, 0));
    }
}
