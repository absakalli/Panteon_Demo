using UnityEngine;

public class CharController : MonoBehaviour
{
    private GameObject child;
    private Animator anim;
    private Rigidbody rb;
    private Vector3 firstPos, lastPos, movePos;
    public float moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        child = transform.GetChild(0).gameObject;
        anim = child.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, 1) * moveSpeed;

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetInteger("run", 1);
            firstPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            if (firstPos == Vector3.zero)
            {
                anim.SetInteger("run", 1);
                firstPos = Input.mousePosition;
            }

            lastPos = Input.mousePosition;
            movePos = lastPos - firstPos;
            movePos.Normalize();

            if (movePos.x < 0)
            {
                anim.SetInteger("turn", 1);
            }

            else if (movePos.x > 0)
            {
                anim.SetInteger("turn", 2);
            }

            else
            {
                anim.SetInteger("turn", 0);
            }

            rb.velocity = new Vector3(movePos.x, 0, 1) * moveSpeed;
        }

        else
        {
            anim.SetInteger("turn", 0);
            firstPos = Vector3.zero;
            lastPos = Vector3.zero;
            movePos = Vector3.zero;
        }
    }
}
