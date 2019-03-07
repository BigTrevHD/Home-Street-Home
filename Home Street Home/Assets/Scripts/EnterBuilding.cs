using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBuilding : MonoBehaviour {
    public int goToScene;
    public int currentScene;


	// Use this for initialization
	void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        SceneManager.LoadScene(goToScene);
    }
	
	// Update is called once per frame
	void Update () {
        currentScene = SceneManager.GetActiveScene().buildIndex;

        
	}

    void OnMouseDown ()
    {
        if (currentScene != 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
