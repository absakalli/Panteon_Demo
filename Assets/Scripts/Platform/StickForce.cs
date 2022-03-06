using UnityEngine;

public class StickForce : MonoBehaviour
{
    RandomizeRotator randomizeRotator;
    private Vector3 forceDirect;

    private void Start()
    {
        randomizeRotator = GameObject.FindObjectOfType<RandomizeRotator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 stickDirect = new Vector3(gameObject.transform.localPosition.x, 0, gameObject.transform.localPosition.z);
        float angle = Vector3.Angle(stickDirect, Vector3.forward);

        if (angle > 90)
        {
            angle = 180 - angle;
        }

        if (randomizeRotator.direction == 1)
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

        else
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

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(forceDirect * 0.000001f * Mathf.Abs(randomizeRotator.velocity));
        }

        if (collision.gameObject.tag == "Opponent")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(forceDirect * 0.000001f * Mathf.Abs(randomizeRotator.velocity));
        }
    }
}
