using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flipper
{
    public class MoverController : MonoBehaviour
    {
        public GameObject gameObjectToMove;
        Transform transformToMove;
        // Use this for initialization
        void Start()
        {
            transformToMove = gameObjectToMove.GetComponent<Transform>();
            /*
            transformToMove.position = new Vector3(
                transformToMove.position.x,
                transformToMove.position.y+10,
                transformToMove.position.z
                );
            */
        }

        // Update is called once per frame
        void Update()
        {
           

        }

        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transformToMove.position = new Vector3(
                     transformToMove.position.x,
                transformToMove.position.y + 0.1f,
                transformToMove.position.z
                    );
            }
        }
    }
}
