using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour {
    private bool showDiary;
    public GameObject Diary;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
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
	}
}
