using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuffyRobot : Robot
{
    new void Start()
    {
        jumpForce = 250.0f;
        base.Start();
    }

    public override void Jump() // POLYMORPHISM
    {
        base.Jump();
        robot.transform.Rotate(0f, 45f, 0f);
    }
}
