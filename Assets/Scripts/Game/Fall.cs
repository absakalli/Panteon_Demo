using UnityEngine;

public class Fall : MonoBehaviour
{
    InstantiatePlatform platform;

    private void Start()
    {
        platform = GameObject.FindObjectOfType<InstantiatePlatform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            platform.instChar.GetComponent<CharController>().enabled = false;
        }

        //if (other.tag == "Opponent")
        //{
        //    other.GetComponent<OpponentController>().enabled = false;
        //}
    }
}
