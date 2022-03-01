using UnityEngine;
using UnityEngine.AI;

public class InstantiatePlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private NavMeshSurface surface;
    [SerializeField] private GameObject[] blocks;
    [SerializeField] private GameObject finish;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject map;

    public GameObject instStart;

    public int mapLenght;

    void Start()
    {
        InstantiateMap();
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
                    clone = Instantiate(platforms[0]
                        , new Vector3(platforms[0].transform.position.x, platforms[0].transform.position.y, 10.8f * i)
                        , Quaternion.Euler(0, 90, 0)
                        , map.GetComponent<Transform>());

                    int randomObstacle = Random.Range(0, 5);

                    clone = Instantiate(blocks[randomObstacle]
                       , new Vector3(blocks[randomObstacle].transform.position.x, blocks[randomObstacle].transform.position.y, 10.8f * i)
                       , Quaternion.identity
                       , map.GetComponent<Transform>());
                }//Platform

                if (randomPlatform == 3)
                {
                    int randomRotatingPlatform = Random.Range(1, 4);

                    clone = Instantiate(platforms[randomRotatingPlatform]
                    , new Vector3(platforms[randomRotatingPlatform].transform.position.x, platforms[randomRotatingPlatform].transform.position.y, 10.8f * i)
                    , Quaternion.identity
                    , map.GetComponent<Transform>());
                }//Rotating Platform
            }

            if (i == mapLenght)
            {
                clone = Instantiate(finish
                        , new Vector3(finish.transform.position.x, finish.transform.position.y, 10.8f * i)
                        , Quaternion.identity
                        , map.GetComponent<Transform>());
            }//Finish Line            
        }
    }
}