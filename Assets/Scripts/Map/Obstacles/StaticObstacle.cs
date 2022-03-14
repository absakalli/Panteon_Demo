using UnityEngine;

public class StaticObstacle : Obstacles
{
    private int RandomX;

    private void Start()
    {
        RandomX = Random.Range(-2, 3);        
        Randomize();
    }

    private void Randomize()
    {
        pos = new Vector3(transform.position.x + RandomX, transform.position.y, transform.position.z);
        transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Lose(collision.gameObject.tag, collision.gameObject);
    }


}
