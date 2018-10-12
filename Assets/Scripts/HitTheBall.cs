using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTheBall : MonoBehaviour {

    public int minSpeed;
    public KeyCode keyCode;
    public int maxSpeed;

    GameObject ball;
    private int speed;
    private bool isCollision;
    Rigidbody rigidBody;



    // Use this for initialization
    void Start()
    {
        isCollision = false;
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnCollisionEnter(Collision collision)
    {

        isCollision = true;
        speed = Random.Range(minSpeed, maxSpeed);

        rigidBody = collision.gameObject.GetComponent<Rigidbody>();
        ball = collision.gameObject;
    }


    private void OnCollisionExit(Collision collision)
    {

        isCollision = false;
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(keyCode))
        {
            if (isCollision)
            {
                rigidBody.AddForce(new Vector3(ball.transform.position.x, ball.transform.position.y, -ball.transform.position.z * speed), ForceMode.Force);
            }
        }

        









    }

}
