using UnityEngine;

public class SetSizeLoseCollider : MonoBehaviour
{
    BoxCollider[] boxColliders;
    InstantiatePlatform platform;

    void Start()
    {
        platform = GameObject.FindObjectOfType<InstantiatePlatform>();
        boxColliders = GetComponents<BoxCollider>();
        foreach (BoxCollider boxCollider in boxColliders)
        {
            boxCollider.size = new Vector3(boxCollider.size.x, boxCollider.size.y, (platform.mapLenght + 1) * 10.8f);
            boxCollider.center = new Vector3(boxCollider.center.x, boxCollider.center.y, ((platform.mapLenght + 1) * 10.8f + 5.4f) / 2);
        }        
    }
}
