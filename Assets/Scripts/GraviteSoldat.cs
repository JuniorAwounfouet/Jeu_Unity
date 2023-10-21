using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraviteSoldat : MonoBehaviour
{
    private GameObject cubeG;
    private float diffY;
    // Start is called before the first frame update
    void Start()
    {
        cubeG = GameObject.Find("GravityCube");
        diffY = cubeG.transform.position.y - this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float y = cubeG.transform.position.y;
        cubeG.transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);
        this.transform.position = new Vector3(this.transform.position.x, y - diffY, this.transform.position.z);
    }
}
