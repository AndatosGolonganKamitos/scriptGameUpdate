using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    private SpriteRenderer sr;
    private Animator anim;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Debug.Log("Horizontal: " + h + " | Vertical: " + v);

        Vector3 arah = new Vector3(h, v, 0);

        transform.Translate(arah * speed * Time.deltaTime, Space.World);

        if (h > 0)
            sr.flipX = false;
        else if (h < 0)
            sr.flipX = true;

        if (h != 0)
            anim.SetBool("IsRunning", true);
        else
            anim.SetBool("IsRunning", false);
    }
}