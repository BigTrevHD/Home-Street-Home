using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {
    public GameObject player;
    public GameObject lastPos;

    private bool showDiary;
    public GameObject Diary;
    public Text cashText; 

    public float cash = 12.0f;
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

    public void BuyFood(float cost)
    {
        if(cash >= cost)
        {
            cash -= cost;
            
        }               
    }

    public void AddToInv(GameObject item)
    {
        if (inv.Slot1Used == 0)
        {
            inv.Slot1 = item;

            inv.Slot1Used = 1;

            if (inv.Slot1Used == 1 & inv.Slot2Used == 0)
            {
                inv.Slot2 = item;
                inv.Slot2Used = 1;

                if (inv.Slot1Used == 1 & inv.Slot2Used == 1 & inv.Slot3Used == 0)
                {
                    inv.Slot3 = item;
                    inv.Slot3Used = 1;
                }
            }
        }

    }
    }

