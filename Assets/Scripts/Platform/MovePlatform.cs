using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Transform>().position += new Vector3(0, 0, -0.1f);
    }
}
