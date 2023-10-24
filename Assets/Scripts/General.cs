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
    private GameObject Joueur;
    private GameObject[] ennemi;
    private NavMeshAgent Soldat;
    private NavMeshAgent Soldat1;
    private NavMeshAgent Soldat2;
    private NavMeshAgent Soldat3;
    private GameObject[] objectsArray = new GameObject[5];

    public int vague;


    private NavMeshAgent Zoombie;

    void Start()
    {
        //objectsArray = new GameObject[5];
        ennemi = new GameObject[20];

        objectsArray[0] = Resources.Load("Soldat") as GameObject;
        objectsArray[1] = Resources.Load("Soldat1") as GameObject;
        objectsArray[2] = Resources.Load("Soldat2") as GameObject;
        objectsArray[3] = Resources.Load("Soldat3") as GameObject;
        objectsArray[4] = Resources.Load("Zoombie") as GameObject;

        for (int i = 0; i < 19; i++)
        {
            ennemi[i] = Instantiate(objectsArray[Random.Range(0, 4)],new Vector3(Random.Range(0, 20),0f, Random.Range(0, 20)),Quaternion.identity);
        }



/*        garde = GameObject.Find("Garde").GetComponent<NavMeshAgent>();
        garde1 = GameObject.Find("Garde1").GetComponent<NavMeshAgent>();

        Soldat = GameObject.Find("Soldat").GetComponent<NavMeshAgent>();
        Soldat1 = GameObject.Find("Soldat1").GetComponent<NavMeshAgent>();
        Soldat2 = GameObject.Find("Soldat2").GetComponent<NavMeshAgent>();
        Soldat3 = GameObject.Find("Soldat3").GetComponent<NavMeshAgent>();
        Zoombie = GameObject.Find("Zoombie").GetComponent<NavMeshAgent>();*/


        Player = GameObject.Find("Player");
        //Soldat = GameObject.Find("Soldat").GetComponent<NavMeshAgent>();

        Joueur = Resources.Load("character") as GameObject;

        //ennemi = Instantiate(Joueur, new Vector3(5,0f,5), Quaternion.identity);

        Camera[] tabCam = FindObjectsOfType<Camera>();

/*        foreach (Camera c in tabCam)
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
        camCourante = camSuivi;*/



    }

    // Update is called once per frame
    void Update()
    {

        //garde.destination = Player.transform.position;
        //garde1.destination = Player.transform.position;
        //Soldat.destination = Player.transform.position;
        //Soldat2.destination = Player.transform.position;

        /*if (Soldat != null)
            Soldat.destination = Player.transform.position;
        if (Soldat1 != null)
            Soldat1.destination = Player.transform.position;
        if(Soldat2 != null)
            Soldat2.destination = Player.transform.position;
        if(Soldat3 != null)
            Soldat3.destination = Player.transform.position;
        if (Zoombie != null)
            Zoombie.destination = Player.transform.position;*/
       /* Debug.Log("actif");

        if (ennemi != null)
        {
            ennemi.GetComponent<NavMeshAgent>().destination = Player.transform.position;
            Debug.Log("ennemi");
        }*/

        for (int i = 0; i < 19; i++)
        {
            if (ennemi[i] != null)
                ennemi[i].GetComponent<NavMeshAgent>().destination = Player.transform.position;
        }

            /* if (Input.GetKeyDown(KeyCode.C))
             {
                 if (camCourante == camSuivi)
                 {
                     camSuivi.enabled = false;
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
             }*/


        }


}
