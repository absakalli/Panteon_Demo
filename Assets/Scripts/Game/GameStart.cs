using DG.Tweening;
using UnityEngine;

public class GameStart : GameObjects
{
    CharactersAnimator charAnim = new CharactersAnimator();
    [SerializeField] private GameObject[] gameObjects;
    [SerializeField] private GameObject boy;
    [SerializeField] private GameObject pointer;
    private Sequence anim;

    private void Start()
    {
        SetAnim();
    }

    private void SetAnim()
    {
        anim = DOTween.Sequence();
        anim.Append(pointer.GetComponent<Transform>().DOLocalMoveX(-177, 1.5f))
            .Append(pointer.GetComponent<Transform>().DOLocalMoveX(195, 1.5f))
            .SetLoops(-1);
    }

    public void Cliked()
    {
        anim.Kill();
        SwitchActivity(gameObjects);
        SwitchActivity(girls);
        charAnim.SetCharAnim(girls);
        charAnim.SetCharAnim(boy);
        boy.GetComponent<PlayerController>().enabled = true;
    }

}
