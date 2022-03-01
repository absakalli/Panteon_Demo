using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Lose : MonoBehaviour
{
    private GameObject start;

    private void Start()
    {
        start = GameObject.FindGameObjectWithTag("Start");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DOTween.KillAll();
            SceneManager.LoadScene(0);
        }

        if (collision.gameObject.tag == "Opponent")
        {
            int randomx = Random.Range(-4, 5);
            int randomz = Random.Range(-2, 2);
            collision.transform.root.position = start.transform.position + new Vector3(randomx, 0, randomz);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            DOTween.KillAll();
            SceneManager.LoadScene(0);
        }

        if (other.tag == "Opponent")
        {
            int randomx = Random.Range(-4, 5);
            int randomz = Random.Range(-2, 2);
            other.transform.root.position = start.transform.position + new Vector3(randomx, 0, randomz);
        }
    }
}
