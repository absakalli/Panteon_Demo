using UnityEngine;

public class RandomizeStaticObstacle : MonoBehaviour
{
    int random;

    void Start()
    {
        random = Random.Range(-3, 4);
        Randomize();
    }

    private void Randomize()
    {
        transform.position = new Vector3(transform.position.x + random, transform.position.y, transform.position.z);
    }
}