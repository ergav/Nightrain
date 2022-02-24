using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Melee : MonoBehaviour
{
    [SerializeField] int damage = 10;
    [SerializeField] float hitForce = 100;
    [SerializeField] float swingCoolDown = 0.8f;
    [SerializeField] float hitRange = 5;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip swingSound, hitSound;
    InputManager inputManager;

    bool swung;

    Rigidbody rb;

    void Start()
    {
        inputManager = InputManager.Instance;
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    void Update()
    {
        if (inputManager.PlayerFireinput() && !swung)
        {
            Swing();
        }
    }

    void Swing()
    {
        Debug.Log("Swoosh!");

        //anim.Play("MeleeSwing");
        if (audioSource != null)
        {
            audioSource.PlayOneShot(swingSound);
        }
        swung = true;
        StartCoroutine(CoolDown());
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, hitRange))
        {
            //if (hit.transform.tag == "Enemy")
            //{
            //    if (hit.transform.GetComponent<EnemyHealth>() != null)
            //    {
            //        eH = hit.transform.GetComponent<EnemyHealth>();
            //        eH.TakeDamage(damage);
            //        audioSource.PlayOneShot(hitSound);

            //    }
            //    else
            //    {
            //        eH = hit.transform.GetComponentInParent<EnemyHealth>();
            //        eH.TakeDamage(damage);
            //        audioSource.PlayOneShot(hitSound);
            //    }
            //}

            if (hit.transform.GetComponent<Rigidbody>() != null)
            {
                rb = hit.transform.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * hitForce);
                if (audioSource != null)
                {
                    audioSource.PlayOneShot(hitSound);
                }
            }
        }
    }

    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(swingCoolDown);
        swung = false;
    }
}
