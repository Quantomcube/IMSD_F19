using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    Vector3 UpDown;
    private float setTime;
    Vector3 positionOffset;
    public AudioSource Potsu;
    private float someAmountOfTime;
    // Start is called before the first frame update
    void Start()
    {
        setTime = 0;
        UpDown = transform.position;
        someAmountOfTime = 5;
    }

    // Update is called once per frame
    void Update()
    {
        setTime += Time.deltaTime;
        transform.position = new Vector3(0, (Mathf.Sin(Time.time) * 5) - 0) + UpDown;
        if (setTime <= someAmountOfTime)
        {
            transform.position = new Vector3(0, Mathf.Sin(Time.time) * 5 - 0) + UpDown;
        }
            if (setTime >= someAmountOfTime)
        {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                Potsu.Play();
                }
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                    Potsu.Stop();
            }
        }
    }
}
