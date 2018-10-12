using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    public string ControllerName = "Enter Name";
    Animator anim;
    public KeyCode keyCode;

	// Use this for initialization
	void Start () {
        Debug.Log(ControllerName);
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(keyCode))
        {
            anim.SetBool("Pressed", true);
        }
		
        if (Input.GetKeyUp(keyCode))
        {
            anim.SetBool("Pressed", false);
        }
	}
}
