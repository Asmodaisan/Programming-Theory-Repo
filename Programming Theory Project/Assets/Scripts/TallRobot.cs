using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallRobot : Robot
{
    new void Start()
    {
        jumpForce = 300.0f;
        base.Start();
    }
}
