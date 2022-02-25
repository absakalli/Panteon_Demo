using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject paintController;
    [SerializeField] private GameObject percentText;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject boy;
    [SerializeField] private GameObject[] girls;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            percentText.SetActive(true);
            wall.SetActive(true);
            paintController.SetActive(true);
            boy.GetComponent<CharAnimatorController>().enabled = true;
            boy.GetComponent<CharController>().enabled = false;
            foreach (GameObject girl in girls)
            {
                if (girl.activeSelf == true)
                {
                    girl.SetActive(false);
                }                
            }
            gameObject.SetActive(false);
        }

        if(other.tag == "Opponent")
        {
            other.gameObject.SetActive(false);
        }
    }
}
