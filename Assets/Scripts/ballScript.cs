using UnityEngine;

public class ballScript : MonoBehaviour
{

    public float minY = -5.5f;
    public float maxVeclocity = 15f;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(transform.position.y < minY)
        {
            transform.position = Vector3.zero;
            rb.linearVelocity = Vector3.zero;
        }

        if(rb.linearVelocity.magnitude > maxVeclocity)
        {
            rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, maxVeclocity);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Brick"))
        {
            Destroy(other.gameObject);
        }
    }
}
