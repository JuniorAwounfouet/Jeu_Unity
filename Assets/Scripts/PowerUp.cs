using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            // Rechager le script d'arme d'une joueur
            GunScript gunScript = player.GetComponent<GunScript>();

            if (gunScript != null && !gunScript.isReloading)
            {
                gunScript.StartCoroutine("Reload_Animation");

                // destroy the PowerUp 
                Destroy(gameObject);
            }
        }
    }
}
