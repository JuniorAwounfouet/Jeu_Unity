using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    //======================== HEALTH
    [Header("Health properties")]
    public Slider healthSlider;
    public Text healthText;

    //======================== SCREEN
    public GameObject pauseScreen;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
