using UnityEngine;

public class FindObjectByTag : MonoBehaviour
{
    void Start()
    {
        GameObject targetObject = GameObject.FindWithTag("Target");

        if (targetObject != null)
        {
            Debug.Log("Найден объект: " + targetObject.name);
        }
        else
        {
            Debug.Log("Объект с тегом 'Target' не найден!");
        }
    }
}
