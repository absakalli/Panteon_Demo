﻿using UnityEngine;

public class InstantiatePlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] blocks;
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private GameObject map;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject opponent;
    [SerializeField] private GameObject character;

    public GameObject instStart;
    public GameObject instChar;
    public GameObject instOppon;

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
        }

        for (int i = 0; i < 10; i = i + 2)
        {
            clone = Instantiate(opponent
                , new Vector3(-4 + i, 0, -4)
                , Quaternion.identity);
        }

        for (int i = 1; i <= 20; i++)
        {
            int random = Random.Range(0, 2);

            if (random == 0)
            {
                clone = Instantiate(platforms[random]
                    , new Vector3(platforms[random].transform.position.x, platforms[random].transform.position.y, 10.8f * i)
                    , Quaternion.identity
                    , map.GetComponent<Transform>());

                int random1 = Random.Range(0, 5);

                clone = Instantiate(blocks[random1]
                   , new Vector3(blocks[random1].transform.position.x, blocks[random1].transform.position.y, 10.8f * i)
                   , Quaternion.identity
                   , map.GetComponent<Transform>());
            }

            else if (random == 1)
            {
                int random2 = Random.Range(1, 4);
                clone = Instantiate(platforms[random2]
                , new Vector3(platforms[random2].transform.position.x, platforms[random2].transform.position.y, 10.8f * i)
                , Quaternion.identity
                , map.GetComponent<Transform>());
            }
        }
    }
}
