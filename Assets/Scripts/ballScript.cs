using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ballScript : MonoBehaviour
{

    public float minY = -5.5f;
    public float maxVeclocity = 15f;

    private Rigidbody2D rb;

    int score = 0;
    int lives = 5;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(transform.position.y < minY)
        {
            transform.position = new Vector3(0,-3,transform.position.z);
            rb.linearVelocity = Vector3.zero;
            lives--;
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
            score++;
        }
    }
}
