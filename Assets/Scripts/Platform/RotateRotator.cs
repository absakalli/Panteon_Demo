using UnityEngine;

public class RotateRotator : MonoBehaviour
{
    int random;
    int random1;

    private void Start()
    {
        random = Random.Range(1, 3);
        random1 = Random.Range(1, 3);
    }

    private void FixedUpdate()
    {
        RotateRotater();
    }

    private void RotateRotater()
    {
        if (random == 1)
        {
            transform.RotateAround(transform.position, Vector3.up, random1);
        }
        
        if (random == 2)
        {
            transform.RotateAround(transform.position, Vector3.up, -random1);
        }
        
    }
}
