using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class General : MonoBehaviour
{
    private NavMeshAgent garde;
    private NavMeshAgent garde1;
    private GameObject Player;
    private NavMeshAgent Soldat;
    private NavMeshAgent Soldat1;
    private NavMeshAgent Soldat2;
    private NavMeshAgent Soldat3;

    // Start is called before the first frame update
    void Start()
    {

        garde = GameObject.Find("Garde").GetComponent<NavMeshAgent>();
        garde1 = GameObject.Find("Garde1").GetComponent<NavMeshAgent>();
        Soldat1 = GameObject.Find("Soldat").GetComponent<NavMeshAgent>();
        Soldat2 = GameObject.Find("Soldat1").GetComponent<NavMeshAgent>();
        Soldat3 = GameObject.Find("Soldat2").GetComponent<NavMeshAgent>();

        Player = GameObject.Find("Player");
        Soldat = GameObject.Find("Soldat").GetComponent<NavMeshAgent>();

        Instantiate(Soldat, new Vector3(5,0f,5), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        //garde.destination = Player.transform.position;
        //garde1.destination = Player.transform.position;
        Soldat.destination = Player.transform.position;
        Soldat1.destination = Player.transform.position;
        Soldat2.destination = Player.transform.position;
        Soldat3.destination = Player.transform.position;


    }
}
