using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public GameManager gameManager;
    public float maxHealth;
    [SerializeField] private float currentHealth;

    private GameObject HealthBar;

    void Start()
    {
        //assign healthbar
        HealthBar = GameObject.Find("Healthbar");
        //assign gameManager
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //Sets max health on healthbar
        HealthBar.GetComponent<Slider>().maxValue = maxHealth;
        //sets current health to max health
        currentHealth = maxHealth;
        //sets actual bar to current health
        HealthBarUpdate();
    }

    public void AddHealth(float value)
    {
        float heal;
        if (currentHealth + value > maxHealth)
        {
            heal = maxHealth - currentHealth;
        }
        else
        {
            heal = value;
        }
        currentHealth += heal;
        HealthBarUpdate();

        
    }

    public void SubtractHealth(float value)
    {
        float damage = value;
        currentHealth -= damage;
        HealthBarUpdate();
        if (currentHealth <= 0)
        {
            gameManager.isGameOver = true;
        }
    }

    private void HealthBarUpdate()
    {
        HealthBar.GetComponent<Slider>().value = currentHealth;
    }
}
