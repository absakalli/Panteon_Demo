using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    int random;

    private void Start()
    {
        random = Random.Range(1, 3);
    }

    private void FixedUpdate()
    {
        RotatePlat();
    }

    private void RotatePlat()
    {
        GameObject rotateChild = transform.GetChild(0).gameObject;

        if (random == 1)
        {
            rotateChild.transform.RotateAround(transform.position, Vector3.forward, 1);
        }

        if (random == 2)
        {
            rotateChild.transform.RotateAround(transform.position, Vector3.forward, -1);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (random == 1)
            {
                collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-0.000003f, 0, 0));
            }

            if (random == 2)
            {
                collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0.000003f, 0, 0));
            }
        }
    }
}

