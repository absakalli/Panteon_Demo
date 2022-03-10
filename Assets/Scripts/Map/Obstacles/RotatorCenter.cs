using UnityEngine;

public class RotatorCenter : Obstacles
{
    Obstacles rotatorCenter = new Obstacles();

    private void OnTriggerEnter(Collider other)
    {
        rotatorCenter.Lose(other.tag, other.gameObject);
    }
}
