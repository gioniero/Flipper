using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour {

    public int value;
    

    private int points;
    

	// Use this for initialization
	void Start () {
        points = 0;
       
	}
	
	// Update is called once per frame
	void Update () {

        
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            points += value;
            Debug.Log(points);
            

        }
    }
}
