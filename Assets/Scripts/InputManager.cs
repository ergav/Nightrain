using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControls playerControls;

    static InputManager _instance;

    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }

        playerControls = new PlayerControls();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return playerControls.Player.ActionMovement.ReadValue<Vector2>();
    }

    public Vector2 GetMouseDelta()
    {
        return playerControls.Player.Look.ReadValue<Vector2>();
    }

    public bool PlayerFireinput()
    {
        return playerControls.Player.Fire.triggered;
    }

    public bool PlayerReloadInput()
    {
        return playerControls.Player.ActionReload.triggered;

    }

    public bool WeaponSlot1()
    {
        return playerControls.Player.WeaponSlot1.triggered;
    }

    public bool WeaponSlot2()
    {
        return playerControls.Player.WeaponSlot2.triggered;
    }

    public bool ActionInteract()
    {
        return playerControls.Player.Interaction.triggered;
    }

    public Vector2 MouseScroll()
    {
        return playerControls.Player.Scroll.ReadValue<Vector2>();
    }

    public bool ActionCrouch()
    {
        return playerControls.Player.ActionCrouch.IsPressed();
    }

    public bool ActionSprint()
    {
        return playerControls.Player.ActionSprint.IsPressed();
    }

}
