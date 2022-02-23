using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, -.1f);
    }
}
