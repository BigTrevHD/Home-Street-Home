using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveChance : MonoBehaviour {
    public int giveChance;
    public int giveAmount;

	// Use this for initialization
	void Start () {
        giveChance = Random.Range(50, 100);
        giveAmount = giveChance / 10;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(this.name +" GA: " + giveAmount + " Chance: " + giveChance);
	}
}
