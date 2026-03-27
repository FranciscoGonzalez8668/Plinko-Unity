using UnityEngine;

public class BallController: MonoBehaviour
{
    [SerializeField]private float force =3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * force);
        }
    }


}

