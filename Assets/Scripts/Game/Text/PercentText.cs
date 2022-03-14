using UnityEngine;
using UnityEngine.UI;

public class PercentText : Texts
{
    [SerializeField] private Text percentageText;
    [SerializeField] private GameObject gameover;

    void Update()
    {
        text = percentageText.text;

        if (text == "100%")
        {
            gameover.SetActive(true);            
        }
    }
}
