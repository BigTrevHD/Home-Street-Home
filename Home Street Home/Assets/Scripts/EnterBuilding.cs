using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBuilding : MonoBehaviour {
    public int goToScene;
    public int currentScene;

    private gameMaster immortal;


	// Use this for initialization
	void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(goToScene);
            immortal.PlayerisSwitching();
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene == 0)
        {            
            Debug.Log("Position: " + PlayerPrefs.GetFloat("X") + PlayerPrefs.GetFloat("Y") + PlayerPrefs.GetFloat("Z"));
        }

        

        
	}

    void OnMouseDown ()
    {
        if (currentScene != 0)
        {            
            SceneManager.LoadScene(0);
            immortal.PlayerIsComingBack();

        }
    }
}
