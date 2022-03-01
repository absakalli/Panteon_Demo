using UnityEngine;

public class CharAnimatorController : MonoBehaviour
{
    Animator anim;
    float animSpeed = 1;

    void Start()
    {
        anim = transform.GetChild(0).GetComponent<Animator>();
    }

    private void FixedUpdate()
    {        
        if (animSpeed > 0)
        {
            animSpeed -= 0.02f;
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, animSpeed+2);
            animSpeed = Mathf.Max(animSpeed, 0);
            anim.speed = animSpeed;
        }

        else
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            anim.speed = 1;
            anim.SetInteger("turn", 0);
            anim.SetInteger("run", 0);
        }        
    }
}
