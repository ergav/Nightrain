using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats : MonoBehaviour
{

    public int currentRevolverAmmo = 6;
    public int currentRevolverReserveAmmo = 6;



    public void GainRevolverAmmo(int amount)
    {
        currentRevolverReserveAmmo += amount;
    }
}
