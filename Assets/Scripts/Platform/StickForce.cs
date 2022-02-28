using System.Collections;
using UnityEngine;

public class StickForce : MonoBehaviour
{
    [SerializeField] private Transform stick;
    [SerializeField] private GameObject boy;

    private Vector3 forceDirect;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 stickDirect = new Vector3(stick.localPosition.x, 0, stick.localPosition.z);
        float angle = Vector3.Angle(stickDirect, Vector3.forward);
        var hinge = GetComponent<HingeJoint>();
        var motor = hinge.motor;

        if (angle > 90)
        {
            angle = 180 - angle;
        }

        if (motor.targetVelocity < 0)
        {
            if (stick.localPosition.x >= 0 && stick.localPosition.z >= 0)
            {
                forceDirect = new Vector3(1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, -1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (stick.localPosition.x < 0 && stick.localPosition.z >= 0)
            {
                forceDirect = new Vector3(1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, 1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (stick.localPosition.x >= 0 && stick.localPosition.z < 0)
            {
                forceDirect = new Vector3(-1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, -1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (stick.localPosition.x < 0 && stick.localPosition.z < 0)
            {
                forceDirect = new Vector3(-1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, 1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }
        }

        else
        {
            if (stick.localPosition.x >= 0 && stick.localPosition.z >= 0)
            {
                forceDirect = new Vector3(-1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, 1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (stick.localPosition.x < 0 && stick.localPosition.z >= 0)
            {
                forceDirect = new Vector3(-1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, -1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (stick.localPosition.x >= 0 && stick.localPosition.z < 0)
            {
                forceDirect = new Vector3(1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, 1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }

            else if (stick.localPosition.x < 0 && stick.localPosition.z < 0)
            {
                forceDirect = new Vector3(1 * Mathf.Cos((angle * Mathf.PI) / 180), 0, -1 * Mathf.Sin((angle * Mathf.PI) / 180));
            }
        }

        if (collision.gameObject.tag == "Player")
        {
            boy.GetComponent<CharController>().enabled = false;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(forceDirect * 0.0001f);
            StartCoroutine("WaitAndPrint");
        }        
    }

    private IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(1f);
        boy.GetComponent<CharController>().enabled = true;
    }
}
