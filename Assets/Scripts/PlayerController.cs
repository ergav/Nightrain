using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed = 2.0f;
    [SerializeField] float jumpHeight = 1.0f;
    [SerializeField] float gravityValue = -9.81f;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    InputManager inputManager;

    Transform cameraTransform;

    [SerializeField] bool isCrouching;
    public bool canRiseFromCrouch = true;

    [SerializeField] float crouchHeight = 0.5f;
    float defaultHeight;
    float defaultCamPos;
    [SerializeField] float crouchCamPos = 0.5f;

    [SerializeField] float crouchTime = 5;

    //[SerializeField] Transform directionPointer;

    float crouchTimer;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
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
        controller.Move(move * Time.deltaTime * playerSpeed);

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
            Debug.Log("Crouching");
        }
        else
        {
            isCrouching = false;

        }

        controller.height = Mathf.Lerp(defaultHeight, crouchHeight, crouchTimer);
        cameraTransform.transform.localPosition = new Vector3(cameraTransform.transform.localPosition.x, Mathf.Lerp(defaultCamPos, crouchCamPos, crouchTimer), cameraTransform.transform.localPosition.z);

        if (isCrouching || !canRiseFromCrouch)
        {
            crouchTimer = Mathf.Clamp01(crouchTimer + Time.deltaTime * crouchTime);

            //if (timer <  crouchTime)
            //{
            //    controller.height = Mathf.Lerp(defaultHeight, crouchHeight, timer / crouchTime);
            //    timer += Time.deltaTime;
            //}
            //else
            //{
            //    controller.height = crouchHeight;
            //}

            //if (controller.height > crouchHeight)
            //{
            //    controller.height = Mathf.Lerp(defaultHeight, crouchHeight, timer / crouchTime);
            //}
            //else
            //{
            //    controller.height = crouchHeight;
            //}

            //controller.height = crouchHeight;
            //cameraTransform.transform.localPosition = new Vector3(cameraTransform.transform.localPosition.x, crouchCamPos, cameraTransform.transform.localPosition.z);
        }
        else
        {
            crouchTimer = Mathf.Clamp01(crouchTimer - Time.deltaTime * crouchTime);


            //if (timer < crouchTime)
            //{
            //    controller.height = Mathf.Lerp(crouchHeight, defaultHeight, timer / crouchTime);
            //    timer += Time.deltaTime;
            //}
            //else
            //{
            //    controller.height = defaultHeight;
            //}

            //controller.height = defaultHeight;
            //cameraTransform.transform.localPosition = new Vector3(cameraTransform.transform.localPosition.x, defaultCamPos, cameraTransform.transform.localPosition.z);
        }

        CheckCanRise();
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
