using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    //public GameObject melee, pistol;

    public List<GameObject> weapons = new List<GameObject>();

    int currentWeapon = 1;

    [SerializeField] int maxWeapons = 6;

    float weaponScrollCurrent;

    InputManager inputManager;

    PlayerAnimations playerAnimations;

    void Start()
    {
        inputManager = InputManager.Instance;
        playerAnimations = GetComponent<PlayerAnimations>();
        SwitchWeapon();
    }

    void Update()
    {
        //switch(currentWeapon)
        //{
        //    case 0:
        //        NoWeapons();
        //        break;
        //    case 1:
        //        MeleeEquipped();
        //        break;
        //    case 2:
        //        PistolEquipped();
        //        break;
        //}

        if (inputManager.WeaponSlot1())
        {
            currentWeapon = 1;
            SwitchWeapon();

        }
        if (inputManager.WeaponSlot2())
        {
            currentWeapon = 2;
            SwitchWeapon();
        }

        Vector2 scroll = inputManager.MouseScroll();

        weaponScrollCurrent = scroll.y;

        if (weaponScrollCurrent == 120)
        {
            Debug.Log("Scroll up");
            if (currentWeapon < weapons.Count)
            {
                currentWeapon++;
            }
            else
            {
                currentWeapon = 1;
            }
            SwitchWeapon();

        }
        else if (weaponScrollCurrent == -120)
        {
            Debug.Log("Scroll down");
            if (currentWeapon > 1)
            {
                currentWeapon--;
            }
            else
            {
                currentWeapon = weapons.Count;
            }
            SwitchWeapon();
        }



    }

    //void NoWeapons()
    //{
    //    melee.SetActive(false);
    //    pistol.SetActive(false);
    //}

    //void MeleeEquipped()
    //{
    //    melee.SetActive(true);
    //    pistol.SetActive(false);
    //}

    //void PistolEquipped()
    //{
    //    melee.SetActive(false);
    //    pistol.SetActive(true);
    //}

    void SwitchWeapon()
    {
        for (int i = 1; i <= weapons.Count; i++)
        {
            if (i == currentWeapon)
            {
                weapons[i-1].SetActive(true);
            }
            else
            {
                weapons[i-1].SetActive(false);
            }

        }
    }
}
