using UnityEngine;

public class GameWin : GameObjects
{
    [SerializeField] private GameObject[] gameObjects;
    [SerializeField] private GameObject boy;

    private void OnCollisionEnter(Collision collision)
    {
        girls = GameObject.FindGameObjectsWithTag("Opponent");

        if (collision.gameObject.tag == "Player")
        {
            SwitchActivity(gameObjects);
            boy.GetComponent<PlayerAnimator>().enabled = true;
            boy.GetComponent<PlayerController>().enabled = false;
            SwitchActivity(girls);
            SwitchActivity(gameObject);
        }

        if (collision.gameObject.tag == "Opponent")
        {
            SwitchActivity(collision.gameObject);
        }
    }
}
