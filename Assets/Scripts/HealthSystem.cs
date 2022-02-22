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

    [SerializeField] private TextMeshProUGUI tmpText;

    private float maxHealth = 100f;

    private WinAndLose winAndLose;

    void Awake()
    {
        winAndLose = FindObjectOfType<WinAndLose>();
    }

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
            winAndLose.GameLost();
            return;
        }
        else if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        tmpText.text = currentHealth.ToString("#");
        slider.value = currentHealth;
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
