using UnityEngine;

public class Frame : Obstacles
{
    private void OnCollisionEnter(Collision collision)
    {
        Lose(collision.gameObject.tag, collision.gameObject);
    }
}
