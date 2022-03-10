using UnityEngine;

public class SetTransformFinish : Platforms
{
    private InstantiateMap platform;
    Platforms finish = new Platforms();

    void Start()
    {
        platform = GameObject.FindObjectOfType<InstantiateMap>();
        finish.pos = new Vector3(transform.position.x, transform.position.y, platform.mapLenght * 10.8f);
        transform.position = finish.pos;
    }
}
