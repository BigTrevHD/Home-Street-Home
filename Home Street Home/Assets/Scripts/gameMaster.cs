using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {
    public GameObject player;

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

    public void PlayerisSwitching()
    {
        PlayerPrefs.SetFloat("X", player.transform.position.x);
        PlayerPrefs.SetFloat("Y", player.transform.position.y);
        PlayerPrefs.SetFloat("Z", player.transform.position.z);
        // Player Switches Scene
    }
    public void PlayerIsComingBack()
    {
        // Player comes back
        player.transform.position = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Z"));
    }
}

