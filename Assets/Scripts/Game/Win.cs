using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject paintController;
    [SerializeField] private GameObject percent;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject rank;
    [SerializeField] private GameObject boy;
    [SerializeField] private GameObject[] girls;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            percent.SetActive(true);
            rank.SetActive(false);
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

    public void Restart()
    {
        DOTween.KillAll();
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
