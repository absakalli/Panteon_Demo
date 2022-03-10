using DG.Tweening;
using UnityEngine;

public class HomeManager : MonoBehaviour
{
    [SerializeField] private GameObject[] girls;
    [SerializeField] private GameObject boy;
    [SerializeField] private GameObject rank;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject pointer;
    [SerializeField] private GameObject holdandmove;

    private Sequence anim;

    private void Start()
    {
        anim = DOTween.Sequence();
        anim.Append(pointer.GetComponent<Transform>().DOLocalMoveX(-177, 1.5f))
            .Append(pointer.GetComponent<Transform>().DOLocalMoveX(195, 1.5f))
            .SetLoops(-1);
    }

    public void Cliked()
    {
        anim.Kill();
        holdandmove.SetActive(false);
        start.SetActive(false);
        rank.SetActive(true);
        boy.GetComponent<CharController>().enabled = true;
        boy.transform.GetChild(0).GetComponent<Animator>().SetInteger("run", 1);
        foreach (GameObject girl in girls)
        {
            girl.SetActive(true);
            girl.transform.GetChild(0).GetComponent<Animator>().SetInteger("run", 1);
        }
    }
}
