using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rummaging : MonoBehaviour
{

    private float randomValue;
    private GameObject bin;

    public bool collided;

    // Use this for initialization
    void Start()
    {
        if (collided == true)
        {
            collided = false;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("r"))
        {
            randomValue = Random.Range(0, 100);
            if (collided == true)
            {


                if (randomValue <= 33)
                {
                    Debug.Log("Found Half Bacon Sandwich");
                }
                else if (randomValue >= 66)
                {
                    Debug.Log("Found Coffee Dregs");
                }
                else
                {
                    Debug.Log("Found Nothing");
                }
            }
        }
    }


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            if (Input.GetKeyDown("r"))
            {
                collided = true;
                Debug.Log("Collided With Bin");
            }
        }
    }
}

