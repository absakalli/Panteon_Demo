using UnityEngine;

public class Map : MonoBehaviour
{
    public Vector3 pos { get; set; }
    public void InstantiateMap(GameObject gameObjects, Quaternion rot, GameObject parent, float z)
    {
        Instantiate(gameObjects,
            new Vector3(gameObjects.transform.position.x,
                        gameObjects.transform.position.y,
                        gameObjects.transform.position.z + z),
            rot, parent.transform);
    }
}
