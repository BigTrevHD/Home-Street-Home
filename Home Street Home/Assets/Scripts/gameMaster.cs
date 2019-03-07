using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {
    private bool showDiary;
    public GameObject Diary;
    public Text cashText; 

    private float cash = 12.0f; 

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
}
