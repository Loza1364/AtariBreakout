using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class ballScript : MonoBehaviour
{

    public float minY = -5.5f;
    public float maxVeclocity = 15f;

    private Rigidbody2D rb;
    public TextMeshPro scoreText;
    public GameObject[] Lives;

    public GameObject gameOverPanel;

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
            if (lives <= 0)
            {
                GameOver();
            }
            else
            {
                transform.position = new Vector3(0, -3, transform.position.z);
                rb.linearVelocity = Vector3.zero;
                lives--;
                Lives[lives].SetActive(false);
            }
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
            scoreText.text = score.ToString("00000");
        }
    }
    void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
        Destroy(gameObject);
    }
}
