using UnityEngine;

public class CharactersAnimator : Characters
{
    public Animator anim { get; set; }

    public float animSpeed { get; set; }

    public void SetCharAnim(GameObject gameObject)
    {
        anim = gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>();
        anim.SetInteger("run", 1);
    }

    public void SetCharAnim(GameObject[] gameObject)
    {
        foreach (GameObject @object in gameObject)
        {
            anim = @object.transform.GetChild(0).gameObject.GetComponent<Animator>();
            anim.SetInteger("run", 1);
        }        
    }
}
