using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movement = 10f;
    Vector3 UpDown;
    // Start is called before the first frame update
    void Start()
    {
        UpDown = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, Mathf.Sin(Time.time) * 5 - 0) + UpDown;

    }
}
