using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flipper
{
    public class PrefabSpawner : MonoBehaviour
    {
        public GameObject Prefab;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(Prefab, transform.position,Quaternion.identity);
            }
            if (Input.GetKeyDown(KeyCode.C))
                {
                if (FindObjectOfType<MoverController>() != null)
                {
                    GameObject.Destroy(FindObjectOfType<MoverController>().gameObject);
                }
            }

        }
    }
}
