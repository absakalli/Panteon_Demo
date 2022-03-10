using UnityEngine;

public class StaticObstacle : Obstacles
{
    private Obstacles staticObstacle = new Obstacles();
    private int RandomX;

    private void Start()
    {
        RandomX = Random.Range(-2, 3);        
        Randomize();
    }

    private void Randomize()
    {
        staticObstacle.pos = new Vector3(transform.position.x + RandomX, transform.position.y, transform.position.z);
        transform.position = staticObstacle.pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        staticObstacle.Lose(collision.gameObject.tag, collision.gameObject);
    }


}
