using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    InstantiatePlatform platform;

    void Start()
    {
        platform = GameObject.FindObjectOfType<InstantiatePlatform>();
    }

    void Update()
    {
        foreach (GameObject obj in platform.objects)
        {
            obj.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
        }
    }
}
