using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Destroy : MonoBehaviour
{
    public int maxHealth, currentHealth;
    public int maxHitCount, currentHitCount;

    [Tooltip("Blood prefab particle this bullet will create upoon hitting enemy")]
    public GameObject bloodEffect;
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

            if ((Physics.Raycast(ray, out hit))&& hit.transform.tag == "Dummie")
            {
                CapsuleCollider cc = hit.collider as CapsuleCollider;
                Debug.Log(hit.collider.GetComponent<NavMeshAgent>().name);
                if (cc != null)
                {
                    NavMeshAgent navMeshAgent = hit.collider.GetComponent<NavMeshAgent>();
                    //navMeshAgent.enabled = false;
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
