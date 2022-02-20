using UnityEngine;

public class InstantiatePlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] blocks;
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private GameObject map;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject opponent;
    [SerializeField] private GameObject character;

    public GameObject instChar;
    public GameObject instOppon;
    public GameObject instStart;

    void Start()
    {
        InstantiateMap();
    }

    private void InstantiateMap()
    {
        GameObject clone;
        clone = Instantiate(character);
        instChar = clone;
        clone = Instantiate(start, map.GetComponent<Transform>());
        instStart = clone;

        for (int i = 0; i < 10; i = i + 2)
        {
            clone = Instantiate(opponent
                , new Vector3(-4 + i, 0, -2)
                , Quaternion.identity);
        }//Opponent

        for (int i = 0; i < 10; i = i + 2)
        {
            clone = Instantiate(opponent
                , new Vector3(-4 + i, 0, -4)
                , Quaternion.identity);
        }//Opponent

        for (int i = 1; i <= 20; i++)
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
        }//Map
    }
}
