using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacles : Map
{ 
    public void Lose(string tag, GameObject gameObject)
    {
        if (tag == "Player")
        {
            DOTween.KillAll();
            SceneManager.LoadScene(0);
        }

        if (tag == "Opponent")
        {
            int randomx = Random.Range(-4, 5);
            int randomz = Random.Range(-2, 2);
            gameObject.transform.root.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.transform.root.position = new Vector3(randomx, 0, randomz); // duzenlenecek
        }
    }
}
