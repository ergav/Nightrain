using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{
    [SerializeField] GameObject lantern;
    InputManager inputManager;

    public bool isOn;

    void Start()
    {
        inputManager = InputManager.Instance;

    }

    void Update()
    {
        if (inputManager.ActionFlashlight())
        {
            isOn = !isOn;
        }

        if (isOn)
        {
            lantern.SetActive(true);
        }
        else
        {
            lantern.SetActive(false);

        }
    }
}
