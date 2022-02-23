using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject melee, pistol;

    int currentWeapon;

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
    }

    void NoWeapons()
    {

    }

    void MeleeEquipped()
    {

    }

    void PistolEquipped()
    {

    }
}
