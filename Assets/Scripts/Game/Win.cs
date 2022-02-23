using UnityEngine;

public class Win : MonoBehaviour
{
    private GameObject percentText;
    private GameObject map;
    private GameObject boy;

    private void Start()
    {
        boy = GameObject.FindGameObjectWithTag("Player");
        map = GameObject.FindGameObjectWithTag("Map");
        percentText = GameObject.FindGameObjectWithTag("Text");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            percentText.GetComponent<CanvasGroup>().alpha = 1;
            map.GetComponent<StopPlatform>().enabled = true;
            map.GetComponent<MovePlatform>().enabled = false;
            boy.GetComponent<CharAnimatorController>().enabled = true;
            boy.GetComponent<CharController>().enabled = false;
            gameObject.SetActive(false);
        }
    }
}
