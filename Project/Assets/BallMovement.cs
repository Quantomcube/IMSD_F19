using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float ballVelocity = 600f;

    private Rigidbody rb;
    private bool ballInPlay;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
        }
    }
}
