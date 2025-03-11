using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) // Нажатие C меняет камеру
        {
            bool isFirstPersonActive = firstPersonCamera.activeSelf;
            firstPersonCamera.SetActive(!isFirstPersonActive);
            thirdPersonCamera.SetActive(isFirstPersonActive);
        }
    }
}
