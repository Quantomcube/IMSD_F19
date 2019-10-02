using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForPaddle : MonoBehaviour
{
    public float paddleSpeed = 1f;

    private Vector3 playerPos = new Vector3(0, -16.3f, 0);
    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -7.7f, 7.7f), -16.3f, 0f);
        transform.position = playerPos;

    }
}
