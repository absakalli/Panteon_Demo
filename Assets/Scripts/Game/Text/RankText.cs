using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankText : Texts
{
    [SerializeField] private Transform boy;
    [SerializeField] private Text rText;
    [SerializeField] private GameObject target;
    private List<float> distance = new List<float>();
    private int rank;

    void Update()
    {
        SortRank();
        text = rank.ToString() + "/" + (girls.Length + 1);
        rText.text = text;
    }

    private void SortRank()
    {
        float boyDistance = target.transform.position.z - boy.position.z;
        distance.Add(boyDistance);
        foreach (GameObject girl in girls)
        {
            float girlDistance = target.transform.position.z - girl.transform.position.z;
            distance.Add(girlDistance);
        }
        distance.Sort();
        rank = distance.IndexOf(boyDistance) + 1;
        distance.Clear();
    }
}