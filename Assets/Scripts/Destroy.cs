using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public GameObject prefab;
    public GameObject startPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(collision.gameObject);
        Instantiate(prefab, startPosition.transform.position, Quaternion.identity);
    }
}
