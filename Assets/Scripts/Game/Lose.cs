using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Lose : MonoBehaviour
{
    InstantiatePlatform platform;

    private void Start()
    {
        platform = GameObject.FindObjectOfType<InstantiatePlatform>();
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
            collision.transform.position = platform.instStart.transform.position + new Vector3(randomx, 0, randomz);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            DOTween.KillAll();
            SceneManager.LoadScene(0);
        }

        if (other.gameObject.tag == "Opponent")
        {
            int randomx = Random.Range(-4, 5);
            int randomz = Random.Range(-2, 2);
            other.transform.position = platform.instStart.transform.position + new Vector3(randomx, 0, randomz);
        }
    }
}
