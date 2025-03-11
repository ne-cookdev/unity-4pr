using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 2, -5);
    public float sensitivity = 3.0f;

    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target.position);
        
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        target.Rotate(Vector3.up * mouseX);
    }
}
