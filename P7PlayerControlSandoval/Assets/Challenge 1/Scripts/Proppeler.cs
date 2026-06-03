using UnityEngine;

public class Proppeler : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * 5);
    }
}
