using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject target;
    public float divisor = 3f;
  
    void Update()
    {
        transform.LookAt(new Vector3(target.transform.position.x/divisor, 0, 0));
    }
}
