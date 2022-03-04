using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject[] girls;
    [SerializeField] private GameObject paintController;
    [SerializeField] private GameObject percent;
    [SerializeField] private GameObject rank;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject boy;

    private void OnCollisionEnter(Collision collision)
    {
        girls = GameObject.FindGameObjectsWithTag("Opponent");

        if (collision.gameObject.tag == "Player")
        {
            percent.SetActive(true);
            rank.SetActive(false);
            wall.SetActive(true);
            paintController.SetActive(true);
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
