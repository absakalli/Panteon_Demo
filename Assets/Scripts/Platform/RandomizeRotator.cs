﻿using UnityEngine;

public class RandomizeRotator : MonoBehaviour
{
    public int velocity;
    public int direction;

    private HingeJoint hinge;
    private JointMotor hingemotor;

    private void Start()
    {
        direction = Random.Range(0, 2);
        velocity = Random.Range(100, 151);

        hinge = GetComponent<HingeJoint>();
        hingemotor = hinge.motor;

        SetVelocity();
    }

    private void SetVelocity()
    {
        if (direction == 0)
        {
            hingemotor.targetVelocity = velocity;
            hinge.motor = hingemotor;
        }

        if (direction == 1)
        {
            hingemotor.targetVelocity = -velocity;
            hinge.motor = hingemotor;
        }
    }
}