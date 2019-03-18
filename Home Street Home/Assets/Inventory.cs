using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public List<GameObject> InventorySlots = new List<GameObject>();

    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;

    public int Slot1Used = 0;
    public int Slot2Used = 0;
    public int Slot3Used = 0;
    public int Slot4Used = 0;
    public int Slot5Used = 0;


    // Use this for initialization
    void Start () {
        InventorySlots.Add(Slot1);
        InventorySlots.Add(Slot2);
        InventorySlots.Add(Slot3);
        InventorySlots.Add(Slot4);
        InventorySlots.Add(Slot5);

    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
