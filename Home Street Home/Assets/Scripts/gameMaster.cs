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

    public float cash = 12.00f;
    //Camera Control
    public Camera cam;
    public Transform mainCam;
    public Transform cafeCam;

    //Scene switch
    public int currentScene;

    //Inventory
    public Inventory inv;



    // Use this for initialization
    void Start () {
        
    	}
	
	// Update is called once per frame
	void Update () {
        cash.ToString("#.00");

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

