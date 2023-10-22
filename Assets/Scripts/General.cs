using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class General : MonoBehaviour
{
    private Camera camSuivi, camDessus, camCourante;


    [Tooltip("Furthest distance bullet will look for target")]
    public float maxDistance = 1000000;
    RaycastHit hit;
    [Tooltip("Prefab of wall damange hit. The object needs 'LevelPart' tag to create decal on it.")]
    public GameObject decalHitWall;
    [Tooltip("Put Weapon layer and Player layer to ignore bullet raycast.")]
    public LayerMask ignoreLayer;
    //public NavMeshAgent Soldat1Prefab;

    private NavMeshAgent garde;
    private NavMeshAgent garde1;
    private GameObject Player;
    private NavMeshAgent Soldat;
    private NavMeshAgent Soldat1;
    private NavMeshAgent Soldat2;
    private NavMeshAgent Soldat3;

    private NavMeshAgent Zoombie;

    void Start()
    {

        garde = GameObject.Find("Garde").GetComponent<NavMeshAgent>();
        garde1 = GameObject.Find("Garde1").GetComponent<NavMeshAgent>();

        Soldat = GameObject.Find("Soldat").GetComponent<NavMeshAgent>();
        Soldat1 = GameObject.Find("Soldat1").GetComponent<NavMeshAgent>();
        Soldat2 = GameObject.Find("Soldat2").GetComponent<NavMeshAgent>();
        Soldat3 = GameObject.Find("Soldat3").GetComponent<NavMeshAgent>();
        Zoombie = GameObject.Find("Zoombie").GetComponent<NavMeshAgent>();


        Player = GameObject.Find("Player");
        //Soldat = GameObject.Find("Soldat").GetComponent<NavMeshAgent>();

        //Instantiate(Soldat1, new Vector3(5,0f,5), Quaternion.identity);

        Camera[] tabCam = FindObjectsOfType<Camera>();

        foreach (Camera c in tabCam)
        {
            if (c.name == "Main Camera")
            {
                camSuivi = c;
                Debug.Log("Cam Suivi OK");
            }
            if (c.name == "CamDessus")
            {
                camDessus = c;
                Debug.Log("Cam Dessus OK");
            }
        }

        camSuivi.enabled = true;
        camDessus.enabled = false;
        camCourante = camSuivi;

    }

    // Update is called once per frame
    void Update()
    {

        //garde.destination = Player.transform.position;
        //garde1.destination = Player.transform.position;
        //Soldat.destination = Player.transform.position;
        //Soldat2.destination = Player.transform.position;

        if (Soldat != null)
            Soldat.destination = Player.transform.position;
        if (Soldat1 != null)
            Soldat1.destination = Player.transform.position;
        if(Soldat2 != null)
            Soldat2.destination = Player.transform.position;
        if(Soldat3 != null)
            Soldat3.destination = Player.transform.position;
        if (Zoombie != null)
            Zoombie.destination = Player.transform.position;


        if (Input.GetKeyDown(KeyCode.C))
        {
            if (camCourante == camSuivi)
            {
                camSuivi.enabled = false;
                camDessus.enabled = true;
                camCourante = camDessus;
                Debug.Log("cameraSuivi");
            }
            else if (camCourante == camDessus)
            {
                camSuivi.enabled = true;
                camDessus.enabled = false;
                camCourante = camSuivi;
                Debug.Log("cameraDessus");

            }
        }


    }


}
