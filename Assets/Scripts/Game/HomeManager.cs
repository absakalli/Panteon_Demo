using DG.Tweening;
using UnityEngine;

public class HomeManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject pointer;
    [SerializeField] private GameObject map;

    Sequence anim;

    void Start()
    {
        anim = DOTween.Sequence();
        anim.Append(pointer.GetComponent<Transform>().DOLocalMoveX(-177, 1.5f))
            .Append(pointer.GetComponent<Transform>().DOLocalMoveX(195, 1.5f))
            .SetLoops(-1);
    }

    public void Cliked()
    {
        anim.Kill();
        canvas.SetActive(false);
        map.GetComponent<MovePlatform>().enabled = true;
    }
}
