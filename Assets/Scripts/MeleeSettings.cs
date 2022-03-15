using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MeleeSettings", menuName = "Melee Settings")]
public class MeleeSettings : ScriptableObject
{
    public int damage = 10;
    public float hitForce = 100;
    public float swingCoolDown = 0.8f;
    public float hitRange = 1.5f;


}
