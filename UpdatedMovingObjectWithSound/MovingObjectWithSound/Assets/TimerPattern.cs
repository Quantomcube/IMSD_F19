using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPattern : MonoBehaviour
{
    private float timer;
    // this variable can be set to whatever amount of time you want.
    private float someAmountOfTime;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        // timer is a variable that will increase every frame by how much time it took since the last frame.
        // This means that any time you use the variable after it has += deltaTime, it will be the amount of time that has passed.
        timer += Time.deltaTime;
        // You can now use this time to make some assessments
        // First for stuff that you might want to continue to happen UNTIL a certain amount of time has passed.
        if (timer <= someAmountOfTime)
        {
            // Because "<=" means less than or equals, for any amount of time that is smaller than the compared value, the code inside this "if" statement will continue to run.
        }
        // Next, for the stuff you want to continue to happen AFTER a certain amount of time has passed.
        if (timer >= someAmountOfTime)
        {
            // Because ">=" means greater than or equals, for any amount of time that is bigger than the compared value, the code inside this "if" statement will continue to run.
        }
    }
}