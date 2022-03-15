using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "WeaponSettings", menuName = "Weapon Settings")]
public class WeaponSettings : ScriptableObject
{
    public int maxAmmo = 6;
    public int maxReserveAmmo = 24;
    public float bulletForce = 100;
    public float maxDistance = 100;
    public int damage = 10;
    public float shootDelaySpeed = 0.2f;
    public float shootCooldownTime = 0.75f;
    public float reloadTime = 1;

}
