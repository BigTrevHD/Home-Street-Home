using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{

    public float Warmth;
    public float warmthOverTimer;

    public float Thirst;
    public float thirstOverTimer;

    public float Hunger;
    public float hungerOverTimer;


    public Slider WarmthBar;
    public Slider ThirstBar;
    public Slider HungerBar;

    public float minAmount = 5f;


    // Use this for initialization
    void Start()
    {
        WarmthBar.maxValue = Warmth;
        ThirstBar.maxValue = Thirst;
        HungerBar.maxValue = Hunger;

        updateUI();
    }

    // Update is called once per frame
    void Update()
    {

        CalculateValues();

    }

    void CalculateValues()
    {
        Hunger -= hungerOverTimer * Time.deltaTime;
        Thirst -= thirstOverTimer * Time.deltaTime;
        Warmth -= warmthOverTimer * Time.deltaTime;


        if (Warmth == 0)
        {
            print("PLAYER IS COLD");
        }

        if (Thirst == 0)
        {
            print("PLAYER IS PARCHED");
        }

        if (Hunger == 0)
        {
            print("PLAYER IS STARVING");
        }

        updateUI();


    }

    void updateUI()
    {
        Warmth = Mathf.Clamp(Warmth, 0, 100f);
        Thirst = Mathf.Clamp(Thirst, 0, 100f);
        Hunger = Mathf.Clamp(Hunger, 0, 100f);


        WarmthBar.value = Warmth;
        ThirstBar.value = Thirst;
        HungerBar.value = Hunger;


    }

    //end of class
}
