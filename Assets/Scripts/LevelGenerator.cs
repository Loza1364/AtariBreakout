using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGenerator : MonoBehaviour
{
    public GameObject brickPrefab;
    public Vector2Int size;
    public Vector2 offset;
    public Gradient gradient;
    private audioManager audioManager;

    void Awake()
    {
        for (int i = 0; i < size.x; i++)
        {
            for (int j = 0; j < size.y; j++)
            {
                GameObject newBrick = Instantiate(brickPrefab, transform);
                newBrick.transform.position = new Vector3((float)((size.x - 1)*.5f-i) * offset.x, j * offset.y, 0);
                newBrick.GetComponent<SpriteRenderer>().color = gradient.Evaluate((float)j / (size.y - 1));
            }
        }
    }
    private void Start()
    {
        audioManager = FindFirstObjectByType<audioManager>();
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        audioManager.SFX(audioManager.click);
    }
}
