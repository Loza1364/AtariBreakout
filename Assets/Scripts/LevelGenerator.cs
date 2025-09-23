using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject brickPrefab;
    public Vector2Int size;
    public Vector2 offset;

    void Awake()
    {
        for (int i = 0; i < size.x; i++)
        {
            for (int j = 0; j < size.y; j++)
            {
                GameObject newBrick = Instantiate(brickPrefab, transform);
                newBrick.transform.position = new Vector3((float)((size.x - 1)*.5f-i) * offset.x, j * offset.y, 0);
            }
        }
    }
}
