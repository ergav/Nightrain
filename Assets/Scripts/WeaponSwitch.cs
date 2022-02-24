using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject melee, pistol;

    int currentWeapon = 1;

    InputManager inputManager;

    void Start()
    {
        inputManager = InputManager.Instance;
    }

    void Update()
    {
        switch(currentWeapon)
        {
            case 0:
                NoWeapons();
                break;
            case 1:
                MeleeEquipped();
                break;
            case 2:
                PistolEquipped();
                break;
        }

        if (inputManager.WeaponSlot1())
        {
            currentWeapon = 1;
        }
        if (inputManager.WeaponSlot2())
        {
            currentWeapon = 2;
        }
    }

    void NoWeapons()
    {
        melee.SetActive(false);
        pistol.SetActive(false);
    }

    void MeleeEquipped()
    {
        melee.SetActive(true);
        pistol.SetActive(false);
    }

    void PistolEquipped()
    {
        melee.SetActive(false);
        pistol.SetActive(true);
    }
}
