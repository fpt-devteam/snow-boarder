using UnityEngine;
public class AutoMove : MonoBehaviour
{
    public float forwardSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(forwardSpeed, rb.linearVelocity.y);
    }
}
