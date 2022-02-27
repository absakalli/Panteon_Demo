using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] private Text percentageText;
    [SerializeField] private GameObject gameover;

    void Update()
    {
        if (percentageText.text == "100%")
        {
            gameover.SetActive(true);
        }
    }
}
