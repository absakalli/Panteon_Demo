using UnityEngine;

public class InstantiatePlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] blocks;
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private GameObject map;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject finish;
    [SerializeField] private GameObject opponent;

    public GameObject instOppon;
    public GameObject instStart;

    public int mapLenght;

    void Start()
    {
        InstantiateMap();
        InstantiateGirl();
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
                int random = Random.Range(0, 4);

                if (random >= 0 && random <= 2)
                {
                    clone = Instantiate(platforms[0]
                        , new Vector3(platforms[0].transform.position.x, platforms[0].transform.position.y, 10.8f * i)
                        , Quaternion.identity
                        , map.GetComponent<Transform>());

                    int random1 = Random.Range(0, 4);

                    if (random1 >= 0 && random1 <= 2)
                    {
                        int random2 = Random.Range(0, 5);

                        clone = Instantiate(blocks[random2]
                           , new Vector3(blocks[random2].transform.position.x, blocks[random2].transform.position.y, 10.8f * i)
                           , Quaternion.identity
                           , map.GetComponent<Transform>());
                    }//Obstacles
                }//Platform

                if (random == 3)
                {
                    int random3 = Random.Range(1, 4);

                    clone = Instantiate(platforms[random3]
                    , new Vector3(platforms[random3].transform.position.x, platforms[random3].transform.position.y, 10.8f * i)
                    , Quaternion.identity
                    , map.GetComponent<Transform>());
                }//Rotating Platform
            }

            if (i == mapLenght)
            {
                clone = Instantiate(platforms[0]
                        , new Vector3(platforms[0].transform.position.x, platforms[0].transform.position.y, 10.8f * i)
                        , Quaternion.identity
                        , map.GetComponent<Transform>());
                clone= Instantiate(finish
                        , new Vector3(finish.transform.position.x, finish.transform.position.y, 10.8f * i)
                        , Quaternion.identity
                        , map.GetComponent<Transform>());
                clone = Instantiate(wall
                        , new Vector3(wall.transform.position.x, wall.transform.position.y, wall.transform.position.z + (10.8f * i))
                        , Quaternion.Euler(-90, 0, 0)
                        , map.GetComponent<Transform>()); ;
            }//Finish Line            
        }
    }

    public void InstantiateGirl()
    {
        GameObject clone;

        for (int i = 0; i < 10; i = i + 2)
        {
            clone = Instantiate(opponent
                , new Vector3(-4 + i, 0, -2)
                , Quaternion.identity);
        }

        for (int i = 0; i < 10; i = i + 2)
        {
            clone = Instantiate(opponent
                , new Vector3(-4 + i, 0, -4)
                , Quaternion.identity);
        }
    }
}
