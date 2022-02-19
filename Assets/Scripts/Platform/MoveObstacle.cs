using UnityEngine;
using DG.Tweening;

public class MoveObstacle : MonoBehaviour
{
    Sequence anim;

    void Start()
    {
        MoveObst();
    }

    private void MoveObst()
    {
        float random = Random.Range(0.9f, 1.6f);
        anim = DOTween.Sequence();
        anim.Append(transform.DOMoveX(-5.5f, random))
            .Append(transform.DOMoveX(5.5f, random))
            .SetLoops(-1);
    }
}
