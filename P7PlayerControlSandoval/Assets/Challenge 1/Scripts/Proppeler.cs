using UnityEngine;

public class Proppeler : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * 5);
    }
}
