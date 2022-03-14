using UnityEngine;

public class PlayerController : CharactersAnimator
{
    private Rigidbody rb;
    private Vector3 firstPos, lastPos, movePos;
    public float moveSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = transform.GetChild(0).gameObject.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        rb.MovePosition(transform.position + (Vector3.forward * moveSpeed * Time.deltaTime));

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

            rb.MovePosition(transform.position + (new Vector3(movePos.x, 0, 1) * moveSpeed * Time.deltaTime));
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
