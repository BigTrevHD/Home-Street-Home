﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

    public Transform sun, moon;

    [SerializeField] int distanceFromOrigin = 10;
    [SerializeField] int orbitAngle;
    [SerializeField] int sunrisePosition;
    [SerializeField] int dayProgress;

    [SerializeField] float daySpeed = .1f;


	// Use this for initialization
	void Start ()
    {

        SetUpOrbitals();
        SetOrbitalPath();

	}

    void SetUpOrbitals()
    {
   
        Vector3 distanceFromOriginVector = new Vector3(distanceFromOrigin, 0, 0);

        sun.position = distanceFromOriginVector;
        moon.position = -distanceFromOriginVector;

        sun.rotation = Quaternion.Euler(0, -90, 0);
        moon.rotation = Quaternion.Euler(0, 90, 0);
    
    }

   void SetOrbitalPath()
    {
        transform.rotation = Quaternion.Euler(orbitAngle,sunrisePosition,dayProgress);
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, 0, daySpeed = 0);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            transform.Rotate(0, 0, daySpeed = .083f);
        }
    
        transform.Rotate(0, 0, daySpeed);
		
	}
}
