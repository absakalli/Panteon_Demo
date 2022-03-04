using UnityEngine;

public class RandomizeStaticObstacle : MonoBehaviour
{
    float random;

    void Start()
    {
        random = Random.Range(-3.5f, 3.51f);
        Randomize();
    }

    private void Randomize()
    {
        transform.position = new Vector3(transform.position.x + random, transform.position.y, transform.position.z);
    }
}