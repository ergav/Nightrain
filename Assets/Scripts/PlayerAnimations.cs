using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator animator;

    public bool walking, sprinting;

    void Start()
    {
        
    }

    void Update()
    {
        animator.SetBool("Walking", walking);
        animator.SetBool("Sprinting", sprinting);

    }

    void Fire()
    {
        animator.SetTrigger("Fire");

    }
}
