using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularRobot : Robot
{
    public override void Start()
    {
        jumpForce = 270.0f;
        base.Start();
    }

    public override void Jump() // POLYMORPHISM
    {
        base.Jump();
        robot.transform.Rotate(0f, 90.0f, 0f);
    }
}
