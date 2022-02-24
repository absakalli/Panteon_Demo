using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject paintController;
    [SerializeField] private GameObject percentText;
    [SerializeField] private GameObject boy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            percentText.SetActive(true);
            paintController.SetActive(true);
            boy.GetComponent<CharAnimatorController>().enabled = true;
            boy.GetComponent<CharController>().enabled = false;
            gameObject.SetActive(false);
        }

        if(other.tag == "Opponent")
        {
            other.gameObject.SetActive(false);
        }
    }
}
