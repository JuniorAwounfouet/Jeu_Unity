using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealthController : MonoBehaviour
{
    public int maxHealth, currentHealth;
    public int maxHitCount, currentHitCount;
    public GameObject blood;

    // Start is called before the first frame update
    void Start()
    {
        blood = GameObject.Find("Blood");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Dummie")
            {
                CapsuleCollider cc = hit.collider as CapsuleCollider;

                if (cc != null)
                {
                    // Essayer de récupérer le compteur de clics de l'objet
                    ClickCounter clickCounter = hit.collider.GetComponent<ClickCounter>();

                    if (clickCounter == null)
                    {
                        // Si l'objet n'a pas de compteur de clics, ajoutez-en un
                        clickCounter = hit.collider.gameObject.AddComponent<ClickCounter>();
                    }

                    // Incrémente le compteur de clics pour cet objet
                    clickCounter.IncrementClickCount();

                    if (clickCounter.GetClickCount() == 2)
                    {
                        // Si le compteur de clics atteint 2, détruisez l'objet
                        Destroy(cc.gameObject);
                        for (int i = 0; i < 10; i++)
                        {
                            Instantiate(blood, hit.point, Quaternion.LookRotation(hit.normal));
                        }
                    }
                }
            }
        }
    }
}


