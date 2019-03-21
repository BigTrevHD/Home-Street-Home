using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {
    public GameObject player;
    public GameObject lastPos;

    private bool showDiary;
    public GameObject Diary;
    public Text cashText; 

    public float cash;
    //Camera Control
    public Camera cam;
    public Transform mainCam;
    public Transform cafeCam;
    public Transform shelterCam;

    //Scene switch
    public int currentScene;

    //Inventory
    public Inventory inv;



    // Use this for initialization
    void Start () {
        cash = 25.50f;
    	}
	
	// Update is called once per frame
	void Update () {
        cash = cash * (1000 / 1000);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            showDiary = !showDiary;
        }

        if (showDiary)
        {
            Diary.SetActive(true);
        }
        else
        {
            Diary.SetActive(false);
        }
        cashText.text = "£" + cash;

        


    }

    public void PlayerisSwitching()
    {
        //PlayerPrefs.SetFloat("X", lastPos.transform.position.x);
        //PlayerPrefs.SetFloat("Y", lastPos.transform.position.y);
        //PlayerPrefs.SetFloat("Z", lastPos.transform.position.z);
        // Player Switches Scene

    }
    public void PlayerIsComingBack()
    {
        // Player comes back
        
    }

 
    }

