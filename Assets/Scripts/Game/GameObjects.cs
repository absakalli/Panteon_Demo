using UnityEngine;

public class GameObjects : MonoBehaviour
{
    public GameObject[] girls;

    public void SwitchActivity(GameObject gameObject)
    {
        if (gameObject.gameObject.activeSelf == true)
        {
            gameObject.gameObject.SetActive(false);
        }
        else
        {
            gameObject.gameObject.SetActive(true);
        }
    }

    public void SwitchActivity(GameObject[] gameObjects)
    {
        foreach (GameObject @object in gameObjects)
        {
            if (@object.gameObject.activeSelf == true)
            {
                @object.gameObject.SetActive(false);
            }
            else
            {
                @object.gameObject.SetActive(true);
            }
        }        
    }    
}
