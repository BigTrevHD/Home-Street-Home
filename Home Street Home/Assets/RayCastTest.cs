using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour {

    public Camera cam;

	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        MouseInput();
    }
    //
    void MouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider.tag == null)
            {
                Debug.Log("null hit");
            }
            else if (hit.collider.tag == "Respawn") // change this to a tag you use
            {
                Debug.Log(hit.collider.gameObject);
               
            }
            else
            {
                Debug.Log("nil");
            }

        }
    }
}
