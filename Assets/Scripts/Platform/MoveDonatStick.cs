using DG.Tweening;
using UnityEngine;

public class MoveDonatStick : MonoBehaviour
{
    Sequence anim;

    void Start()
    {
        MoveDonatLeft();
    }

    private void MoveDonatLeft()
    {
        float random = Random.Range(0.6f, 1.1f);
        anim = DOTween.Sequence();
        anim.Append(transform.DOLocalMoveX(-0.125f, random).SetEase(Ease.InQuart))
            .Append(transform.DOLocalMoveX(0.15f, random))
            .SetLoops(-1);
    }
}
