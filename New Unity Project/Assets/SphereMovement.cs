using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    int randomXPositionThatIsLeftOrRight;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        MoveTheSphereToEitherTheLeftOrRightOfScreen();
    }

    void MoveTheSphereToEitherTheLeftOrRightOfScreen()
    {
        randomXPositionThatIsLeftOrRight = Random.Range(0, 2);
        transform.position = new Vector3(-10 + 20 * randomXPositionThatIsLeftOrRight, transform.position.y, transform.position.z);
    }

    
}
