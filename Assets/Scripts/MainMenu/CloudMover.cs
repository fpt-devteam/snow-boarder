using UnityEngine;

public class CloudMover : MonoBehaviour
{
    public float speed = 0.5f;
    public float resetX = 10f;
    public float startX = -10f;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (transform.position.x > resetX)
        {
            Vector3 pos = transform.position;
            pos.x = startX;
            transform.position = pos;   
        }
    }
}
