using UnityEngine;
using UnityEngine.AI;

public class InstantiatePlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private GameObject[] blocks;
    [SerializeField] private NavMeshSurface surface;
    [SerializeField] private GameObject frames;
    [SerializeField] private GameObject frame;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject map;

    public GameObject instStart;

    public int mapLenght;

    void Start()
    {
        InstantiateMap();
        InstantiateFrame();
        surface.BuildNavMesh();
    }

    private void InstantiateMap()
    {
        GameObject clone;
        clone = Instantiate(start, map.GetComponent<Transform>());
        instStart = clone;

        for (int i = 1; i <= mapLenght; i++)
        {
            if (i < mapLenght)
            {
                int randomPlatform = Random.Range(0, 4);

                if (randomPlatform >= 0 && randomPlatform <= 2)
                {
                    Instantiate(platforms[0]
                       , new Vector3(platforms[0].transform.position.x, platforms[0].transform.position.y, 10.8f * i)
                       , Quaternion.Euler(0, 90, 0)
                       , map.GetComponent<Transform>());

                    int randomObstacle = Random.Range(0, 5);

                    Instantiate(blocks[randomObstacle]
                       , new Vector3(blocks[randomObstacle].transform.position.x, blocks[randomObstacle].transform.position.y, 10.8f * i)
                       , Quaternion.identity
                       , map.GetComponent<Transform>());
                }//Platform

                if (randomPlatform == 3)
                {
                    int randomRotatingPlatform = Random.Range(1, 4);

                    Instantiate(platforms[randomRotatingPlatform]
                       , new Vector3(platforms[randomRotatingPlatform].transform.position.x, platforms[randomRotatingPlatform].transform.position.y, 10.8f * i)
                       , Quaternion.identity
                       , map.GetComponent<Transform>());
                }//Rotating Platform
            }
        }
    }

    private void InstantiateFrame()
    {
        GameObject clone;
        int frameCount = 0;
        while (true)
        {
            Instantiate(frame
                , new Vector3(frame.transform.position.x, frame.transform.position.y, frame.transform.position.z + frameCount * 1.5f)
                , Quaternion.Euler(0, 90, 0)
                , frames.GetComponent<Transform>());

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