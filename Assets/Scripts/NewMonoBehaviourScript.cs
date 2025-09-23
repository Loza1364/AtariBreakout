using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Horizontal movement variables(basic)
    private float xInput;
    public float xSpeed = 5f;
    public float maxX = 7.5f;

    void Start()
    {
        transform.position = new Vector3(0, transform.position.y, 0);
    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        if (Mathf.Abs(transform.position.x + (xInput*1)) < maxX)
        {
            transform.position += Vector3.right * xInput * xSpeed * Time.deltaTime;
        }
    }
}
