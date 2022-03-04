using UnityEngine;

public class SetTransformFinish : MonoBehaviour
{
    InstantiatePlatform platform;

    void Start()
    {
        platform = GameObject.FindObjectOfType<InstantiatePlatform>();
        transform.position = new Vector3(transform.position.x, transform.position.y, platform.mapLenght * 10.8f);
    }
}
