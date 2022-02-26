using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankController : MonoBehaviour
{
    [SerializeField] private Transform boy;
    [SerializeField] private Transform target;
    [SerializeField] private Transform[] girls;
    [SerializeField] private Text text;

    List<float> distance = new List<float>();
    private int rank;

    void Update()
    {
        SortRank();
        text.text = rank.ToString() + "/" + (girls.Length + 1);
    }

    private void SortRank()
    {
        float boyDistance = target.position.z - boy.position.z;
        distance.Add(boyDistance);

        foreach (Transform girl in girls)
        {
            float girlDistance = target.position.z - girl.position.z;
            distance.Add(girlDistance);
        }

        distance.Sort();
        rank = distance.IndexOf(boyDistance) + 1;
        distance.Clear();
    }
}