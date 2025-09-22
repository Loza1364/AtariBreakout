using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Horizontal movement variables(basic)
    private float xInput;
    public float xSpeed = 5f;

    void Start()
    {
        transform.position = new Vector3(0, -3, 0);
    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * xInput * xSpeed * Time.deltaTime);
    }
}
