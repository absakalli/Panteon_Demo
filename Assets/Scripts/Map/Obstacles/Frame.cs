using UnityEngine;

public class Frame : Obstacles
{
    Obstacles frame = new Obstacles();

    private void OnCollisionEnter(Collision collision)
    {
        frame.Lose(collision.gameObject.tag, collision.gameObject);
    }
}
