using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private Variables
    private float speed = 20;
    private float turnspeed 25;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform. Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
        
    }
}
