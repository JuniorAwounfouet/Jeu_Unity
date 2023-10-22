using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Responsible to manage the health of the player
*/ 
public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;

    public int maxHealth, currentHealth;

    public float invincibleLength = 1.0f;
    public float invincCounter;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        /*currentHealth = maxHealth;*/
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentHealth);

        if (invincCounter > 0)
        {
            invincCounter -= Time.deltaTime;
        }
    }

    public void HealPlayer(int healAmount)
    {
        currentHealth += healAmount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
