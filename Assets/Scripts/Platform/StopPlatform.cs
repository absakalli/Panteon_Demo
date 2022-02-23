using UnityEngine;

public class StopPlatform : MonoBehaviour
{
    float platformSpeed = -0.1f;

    private void FixedUpdate()
    {
        if (platformSpeed < 0)
        {
            platformSpeed += 0.002f;
            platformSpeed = Mathf.Min(platformSpeed, 0);
            transform.position += new Vector3(0, 0, platformSpeed);
        }
    }
}

