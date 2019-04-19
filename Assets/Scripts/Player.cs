using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Ball Ball;
    public GameObject PlayerCamera;
    public float BallDistance = 2.25f;
    public float BallThrowingForce = 5f;

    public bool HoldingBall = true;
    // Start is called before the first frame update
    void Start()
    {
        Ball.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (HoldingBall)
        {
            Ball.transform.position = PlayerCamera.transform.position + PlayerCamera.transform.forward * BallDistance;
            if (Input.GetMouseButton(0))
            {
                HoldingBall = false;
                Ball.ActivateTrail();
                Ball.GetComponent<Rigidbody>().useGravity = true;
                Ball.GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * BallThrowingForce);
            }
        }
    }
}
