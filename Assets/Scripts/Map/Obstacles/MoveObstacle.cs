using UnityEngine;
using DG.Tweening;

public class MoveObstacle : Obstacles
{
    private Obstacles moveObtacle = new Obstacles();
    private Sequence anim;
    private int random;

    private void Start()
    {
        random = Random.Range(0, 2);
        ChangePos();
        MoveObst();
    }

    private void ChangePos()
    {
        if (random == 0)
        {
            moveObtacle.pos = new Vector3(-5.5f, transform.position.y, transform.position.z);
            transform.position = moveObtacle.pos;
        }
    }

    private void MoveObst()
    {
        float random1 = Random.Range(0.9f, 1.6f);
        anim = DOTween.Sequence();

        if (random == 0)
        {
            anim.Append(transform.DOMoveX(5.5f, random1))
                .Append(transform.DOMoveX(-5.5f, random1))
                .SetLoops(-1);
        }

        else
        {
            anim.Append(transform.DOMoveX(-5.5f, random1))
                .Append(transform.DOMoveX(5.5f, random1))
                .SetLoops(-1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        moveObtacle.Lose(collision.gameObject.tag, collision.gameObject);
    }
}
