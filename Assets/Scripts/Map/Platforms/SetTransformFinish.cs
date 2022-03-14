using UnityEngine;

public class SetTransformFinish : Platforms
{
    private InstantiateMap platform;

    private void Start()
    {
        platform = GameObject.FindObjectOfType<InstantiateMap>();
        pos = new Vector3(transform.position.x, transform.position.y, platform.mapLenght * 10.8f);
        transform.position = pos;
    }
}
