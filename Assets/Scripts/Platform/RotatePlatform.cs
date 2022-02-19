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
}

