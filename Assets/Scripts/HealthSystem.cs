using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthSystem : MonoBehaviour
{
    public Slider slider;
    public float currentHealth;
    public float damage;
    public float healingPoints;
    private float maxHealth = 100f;

    [SerializeField] private TextMeshProUGUI tmpText;


    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = maxHealth;
        currentHealth = maxHealth;
        slider.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            tmpText.text = "0";
            Death();
            return;
        }
        else if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        tmpText.text = currentHealth.ToString("#");
        slider.value = currentHealth;
    }

    public void Death()
    {
        Debug.Log("player is dead");
        // reference to Win&Lose System script.Lose();
    }

    public void RestoreHealth(float healingPoints)
    {
        Debug.Log("player heals");
        currentHealth += healingPoints;
    }

    public void TakeDamage(float damage)
    {
        Debug.Log("player takes damage");
        currentHealth -= damage;
    }
}
