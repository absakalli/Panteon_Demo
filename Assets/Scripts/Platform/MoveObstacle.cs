using UnityEngine;
using DG.Tweening;

public class MoveObstacle : MonoBehaviour
{
    Sequence anim;
    private int random;

    void Start()
    {
        random = Random.Range(0, 2);
        ChangePos();
        MoveObst();
    }

    private void ChangePos()
    {
        if (random == 0)
        {
            gameObject.transform.position = new Vector3(-5.5f, transform.position.y, transform.position.z);
        }
    }

    private void MoveObst()
    {
        float random1 = Random.Range(0.9f, 1.6f);

        if (random == 0)
        {
            anim = DOTween.Sequence();
            anim.Append(transform.DOMoveX(5.5f, random1))
                .Append(transform.DOMoveX(-5.5f, random1))
                .SetLoops(-1);
        }

        else
        {
            anim = DOTween.Sequence();
            anim.Append(transform.DOMoveX(-5.5f, random1))
                .Append(transform.DOMoveX(5.5f, random1))
                .SetLoops(-1);
        }        
    }
}
