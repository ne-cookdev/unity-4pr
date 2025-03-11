using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 5.0f;
    private float translationZ = 0f;
    private float translationX = 0f;
    private float translationY = 0f;

    private bool jump;

    private GameObject sphere;

    private CharacterController CharacterController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sphere = GameObject.Find("Sphere");
        CharacterController = sphere.GetComponent<CharacterController>();
        jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(sphere.GetComponent<Rigidbody>().linearVelocity);
        translationX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        translationZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 movement = new Vector3(translationX, translationY, translationZ);

        movement = transform.TransfromDirection(movement);
        movement = Vector3.ClampMagnitude(movement, speed);

        CharacterController.Move(movement);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit){
        Rigidbody rb1 = hit.collider.attachedRigidbody;
        if(rb1!= null){
            rb1.linearVelocity = hit.moveDirection * 5f;
        }
    }
}
