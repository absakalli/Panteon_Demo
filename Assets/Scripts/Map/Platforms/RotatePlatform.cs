using UnityEngine;

public class RotatePlatform : Platforms
{
    private int directionRotate;

    private void Start()
    {
        directionRotate = Random.Range(1, 3);
    }

    private void FixedUpdate()
    {
        RotatePlatf();
    }

    private void RotatePlatf()
    {
        GameObject rotateChild = transform.GetChild(0).gameObject;

        if (directionRotate == 1)
        {
            rotateChild.transform.RotateAround(transform.position, Vector3.forward, 1);
        }

        if (directionRotate == 2)
        {
            rotateChild.transform.RotateAround(transform.position, Vector3.forward, -1);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (directionRotate == 1)
            {
                other.GetComponent<Rigidbody>().AddForce(new Vector3(-0.00000175f, 0, 0));
            }

            if (directionRotate == 2)
            {
                other.GetComponent<Rigidbody>().AddForce(new Vector3(0.00000175f, 0, 0));
            }
        }

        if (other.tag == "Opponent")
        {
            if (directionRotate == 1)
            {
                other.transform.position += Vector3.left * 0.033f;
            }

            if (directionRotate == 2)
            {
                other.transform.position += Vector3.right * 0.033f;
            }
        }
    }
}

