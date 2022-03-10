using UnityEngine;
using UnityEngine.AI;

public class InstantiateMap : Map
{
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private GameObject[] blocks;
    [SerializeField] private NavMeshSurface surface;
    [SerializeField] private GameObject frames;
    [SerializeField] private GameObject frame;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject map;
    private Map insMap = new Map();
    public int mapLenght;

    void Start()
    {
        InsMap();
        InsFrame();
        surface.BuildNavMesh();
    }

    private void InsMap()
    {
        insMap.InstantiateMap(start, Quaternion.identity, map, 0); //Start
        for (int i = 1; i <= mapLenght; i++)
        {
            if (i < mapLenght)
            {
                int randomPlatform = Random.Range(0, 4);

                if (randomPlatform >= 0 && randomPlatform <= 2)
                {
                    insMap.InstantiateMap(platforms[0], Quaternion.Euler(0, 90, 0), map, i * 10.8f); //Platform
                    int randomObstacle = Random.Range(0, 5);
                    insMap.InstantiateMap(blocks[randomObstacle], Quaternion.identity, map, i * 10.8f); //Obstacles
                }

                if (randomPlatform == 3)
                {
                    int randomRotatingPlatform = Random.Range(1, 4);
                    insMap.InstantiateMap(platforms[randomRotatingPlatform], Quaternion.identity, map, i * 10.8f); //Rotating Platform
                }
            }
        }
    }

    private void InsFrame()
    {
        GameObject clone;
        int frameCount = 0;
        while (true)
        {
            insMap.InstantiateMap(frame, Quaternion.Euler(0, 90, 0), frames, frameCount * 1.5f);

            clone = Instantiate(frame
                , new Vector3(-frame.transform.position.x, frame.transform.position.y, frame.transform.position.z + frameCount * 1.5f)
                , Quaternion.Euler(0, -90, 0)
                , frames.GetComponent<Transform>());

            if (clone.transform.position.z < mapLenght * 10.8f)
            {
                frameCount++;
                continue;
            }

            else
            {
                break;
            }
        }
    }
}