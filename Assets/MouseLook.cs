using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 10f;
    private float rotationX = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        rotationX += Input.GetAxis("Mouse Y") * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -45, 45f);

        float rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
