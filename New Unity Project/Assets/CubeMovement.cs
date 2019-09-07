using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float speed = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        // Not used
    }

    // Update is called once per frame
    void Update()
    {
        int randomInt = Random.Range(-10,11);

        transform.position += new Vector3(0,0,randomInt);
    }

    
}