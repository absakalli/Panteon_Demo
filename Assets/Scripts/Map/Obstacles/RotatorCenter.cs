using UnityEngine;

public class RotatorCenter : Obstacles
{
    private void OnTriggerEnter(Collider other)
    {
        Lose(other.tag, other.gameObject);
    }
}
