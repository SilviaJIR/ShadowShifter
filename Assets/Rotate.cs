using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
  public float speed = 1f;
  private bool ctrlled = false;
    
  Ray ray;
  RaycastHit hit;
    

  void OnMouseOver()
    {
        print ("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        print ("Mouse is no longer on GameObject.");
    }


  void Update ()
  {

     ray = Camera.main.ScreenPointToRay(Input.mousePosition);

     if(Physics.Raycast(ray, out hit))
     {
        ctrlled = true;
       // print ("ttt");
     } else {
        ctrlled = false;
       // print ("fff");

     }



     //if (ctrlled) {
     if (Input.GetKey(KeyCode.LeftArrow)) {
       transform.Rotate(Vector3.up, speed, Space.World);
     }

     if (Input.GetKey(KeyCode.RightArrow)) {
       transform.Rotate(Vector3.down, speed, Space.World);
     }

     if (Input.GetKey(KeyCode.UpArrow)) {
       transform.Rotate(Vector3.right, speed, Space.World);
     }

     if (Input.GetKey(KeyCode.DownArrow)) {
       transform.Rotate(Vector3.left, speed, Space.World);
     }
    // }

  }

}


