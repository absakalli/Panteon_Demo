using UnityEngine;

public class Win : MonoBehaviour
{
    private GameObject paintController;
    private GameObject[] girls;
    private GameObject percent;
    private GameObject finish;
    private GameObject rank;
    private GameObject boy;

    private void Start()
    {
        paintController = GameObject.FindWithTag("Paint");
        percent = GameObject.FindWithTag("PercentText");
        finish = GameObject.FindWithTag("FinishLine");
        rank = GameObject.FindWithTag("RankText");
        boy = GameObject.FindWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        girls = GameObject.FindGameObjectsWithTag("Opponent");

        if (collision.gameObject.tag == "Player")
        {
            percent.GetComponent<CanvasGroup>().alpha = 1;
            rank.GetComponent<CanvasGroup>().alpha = 0;
            finish.transform.GetChild(2).gameObject.SetActive(true);
            paintController.transform.GetChild(0).gameObject.SetActive(true);
            boy.GetComponent<CharAnimatorController>().enabled = true;
            boy.GetComponent<CharController>().enabled = false;
            foreach (GameObject girl in girls)
            {
                girl.transform.root.gameObject.SetActive(false);
            }
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Opponent")
        {
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
