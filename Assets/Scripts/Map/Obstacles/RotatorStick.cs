using UnityEngine;

public class RotatorStick : Obstacles
{
    private Vector3 forceDirect;
    private int velocity;
    private int direction;
    private HingeJoint hinge;
    private JointMotor hingemotor;

    private void Start()
    {
        velocity = Random.Range(100, 151);
        direction = Random.Range(0, 2);
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

    private void GetArea()
    {
        Vector3 stickDirect = new Vector3(gameObject.transform.localPosition.x, 0, gameObject.transform.localPosition.z);
        float angle = Vector3.Angle(stickDirect, Vector3.forward);

        if (angle > 90)
        {
            angle = 180 - angle;
        }

        if (direction == 0)
        {
            if (gameObject.transform.localPosition.x >= 0 && gameObject.transform.localPosition.z >= 0)
            {
                forceDirect = new Vector3(1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, -1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (gameObject.transform.localPosition.x < 0 && gameObject.transform.localPosition.z >= 0)
            {
                forceDirect = new Vector3(1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, 1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (gameObject.transform.localPosition.x >= 0 && gameObject.transform.localPosition.z < 0)
            {
                forceDirect = new Vector3(-1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, -1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (gameObject.transform.localPosition.x < 0 && gameObject.transform.localPosition.z < 0)
            {
                forceDirect = new Vector3(-1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, 1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }
        }

        if (direction == 1)
        {
            if (gameObject.transform.localPosition.x >= 0 && gameObject.transform.localPosition.z >= 0)
            {
                forceDirect = new Vector3(-1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, 1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (gameObject.transform.localPosition.x < 0 && gameObject.transform.localPosition.z >= 0)
            {
                forceDirect = new Vector3(-1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, -1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (gameObject.transform.localPosition.x >= 0 && gameObject.transform.localPosition.z < 0)
            {
                forceDirect = new Vector3(1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, 1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (gameObject.transform.localPosition.x < 0 && gameObject.transform.localPosition.z < 0)
            {
                forceDirect = new Vector3(1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, -1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }
        }
    }

    private void ApplyForce(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(forceDirect * 0.000001f * Mathf.Abs(velocity));
        }

        if (collision.gameObject.tag == "Opponent")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(forceDirect * 0.000001f * Mathf.Abs(velocity));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetArea();
        ApplyForce(collision);
    }

}
