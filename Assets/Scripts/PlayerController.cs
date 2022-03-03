using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float walkSpeed = 2.0f;
    [SerializeField] float sprintSpeed = 6.0f;
    [SerializeField] float jumpHeight = 1.0f;
    [SerializeField] float gravityValue = -9.81f;
    private CharacterController controller;
    private CapsuleCollider capsuleCollider;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    InputManager inputManager;

    Transform cameraTransform;

    [SerializeField] bool isCrouching;
    [SerializeField] bool isSprinting;
    public bool canRiseFromCrouch = true;

    [SerializeField] float crouchHeight = 0.5f;
    float defaultHeight;
    float defaultCamPos;
    [SerializeField] float crouchCamPos = 0.5f;

    [SerializeField] float crouchTime = 5;
    [SerializeField] float sprintTime;

    //[SerializeField] Transform directionPointer;

    float crouchTimer;
    float speed;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        inputManager = InputManager.Instance;
        cameraTransform = Camera.main.transform;

        defaultHeight = controller.height;
        defaultCamPos = cameraTransform.transform.localPosition.y;

    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movement = inputManager.GetPlayerMovement();
        Vector3 move = new Vector3(movement.x, 0f, movement.y);
        move = transform.forward * move.z + transform.right * move.x;
        move.y = 0;
        controller.Move(move * Time.deltaTime * speed);

        if (isSprinting)
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = walkSpeed;
        }

        //if (move != Vector3.zero)
        //{
        //    gameObject.transform.forward = move;
        //}

        // Changes the height position of the player..
        //if (Input.GetButtonDown("Jump") && groundedPlayer)
        //{
        //    playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        //}

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);


        //Crouch
        if (inputManager.ActionCrouch())
        {

            isCrouching = true;
        }
        else
        {
            if (canRiseFromCrouch)
            {
                isCrouching = false;

            }
            else
            {
                isCrouching = true;
            }
        }

        controller.height = Mathf.Lerp(defaultHeight, crouchHeight, crouchTimer);
        cameraTransform.transform.localPosition = new Vector3(cameraTransform.transform.localPosition.x, Mathf.Lerp(defaultCamPos, crouchCamPos, crouchTimer), cameraTransform.transform.localPosition.z);

        if (isCrouching)
        {
            canRiseFromCrouch = CheckCanRise();
        }

        if (isCrouching || !canRiseFromCrouch)
        {
            crouchTimer = Mathf.Clamp01(crouchTimer + Time.deltaTime * crouchTime);

        }
        else
        {
            crouchTimer = Mathf.Clamp01(crouchTimer - Time.deltaTime * crouchTime);

        }


        //Sprint
        if (inputManager.ActionSprint() && !isCrouching)
        {

            isSprinting = true;
        }
        else
        {
            isSprinting = false;

        }


        if (capsuleCollider != null)
        {
            capsuleCollider.height = controller.height;
        }
    }

    bool CheckCanRise()
    {
        Ray checkCeiling = new Ray(transform.position, transform.up);
        RaycastHit hit;
        if (Physics.Raycast(checkCeiling, out hit, 1.2f))
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}
