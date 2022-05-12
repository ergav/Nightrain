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

    public void Fire()
    {
        animator.SetTrigger("Fire");

    }

    public void Reload()
    {
        animator.SetTrigger("Reload");

    }
}
