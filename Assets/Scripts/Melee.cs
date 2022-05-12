using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Melee : MonoBehaviour
{
    [SerializeField] MeleeSettings meleeSettings;

    //[SerializeField] int damage = 10;
    //[SerializeField] float hitForce = 100;
    //[SerializeField] float swingCoolDown = 0.8f;
    //[SerializeField] float hitRange = 1.5f;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip swingSound;
    [SerializeField] AudioClip hitSound;
    InputManager inputManager;

    bool swung;

    Rigidbody rb;

    PlayerAnimations playeranimations;

    void Start()
    {
        inputManager = InputManager.Instance;
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = GetComponentInParent<AudioSource>();
            }
        }
        playeranimations = GetComponentInParent<PlayerAnimations>();
    }
    float timer;
    void Update()
    {
        if (inputManager.PlayerFireinput() && !swung)
        {
            Swing();
        }

        if (swung)
        {
            timer += Time.deltaTime;
            if (timer > meleeSettings.swingCoolDown)
            {
                swung = false;
                timer = 0;
            }
        }
    }

    void Swing()
    {
        Debug.Log("Swoosh!");
        playeranimations.Fire();
        //anim.Play("MeleeSwing");
        if (swingSound != null)
        {
            audioSource.PlayOneShot(swingSound);
        }
        swung = true;
        //StartCoroutine(CoolDown());
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, meleeSettings.hitRange))
        {
            //if (hit.transform.tag == "Enemy")
            //{
            //    if (hit.transform.GetComponent<EnemyHealth>() != null)
            //    {
            //        eH = hit.transform.GetComponent<EnemyHealth>();
            //        eH.TakeDamage(meleeSettings.damage);
            //        audioSource.PlayOneShot(hitSound);

            //    }
            //    else
            //    {
            //        eH = hit.transform.GetComponentInParent<EnemyHealth>();
            //        eH.TakeDamage(meleeSettings.damage);
            //        audioSource.PlayOneShot(hitSound);
            //    }
            //}

            if (hit.transform.GetComponent<Rigidbody>() != null)
            {
                rb = hit.transform.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * meleeSettings.hitForce);
                if (hitSound != null)
                {
                    audioSource.PlayOneShot(hitSound);
                }
            }
        }
    }

    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(meleeSettings.swingCoolDown);
        swung = false;
    }
}
