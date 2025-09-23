using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject target;
  
    void Update()
    {
        transform.LookAt(new Vector3(target.transform.position.x/3, 0, 0));
    }
}
