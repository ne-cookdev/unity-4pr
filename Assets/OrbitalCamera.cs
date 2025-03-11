using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject Target;
    [SerializeField]
    private Transform lookPosition;
    private Vector3 offset;
    private float deltaY;
    private float sensetivity = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = Target.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        deltaY += Input.GetAxis("Mouse X") * sensetivity;
        Quaternion rotation = Quaternion.Euler(0, deltaY, 0);
        transform.position = Target.transform.position - (rotation * offset);
        transform.LookAt(lookPosition.position);
    }
}
