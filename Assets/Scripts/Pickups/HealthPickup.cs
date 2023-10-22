using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    private bool isCollected = false;

    public int healAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !isCollected)
        {
            Debug.Log("Is the player");

            PlayerHealthController.instance.HealPlayer(healAmount);

            /*UIController.HealthBar += 50;*/

            Object.Destroy(gameObject);
        }
    }
}
