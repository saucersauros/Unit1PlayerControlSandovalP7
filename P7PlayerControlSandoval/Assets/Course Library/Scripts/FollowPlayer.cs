using UnityEngine;

public class FollowPlayer1 : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 5, -7);
    public GameObject player;
    public GameObject camera;
   
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            offset = new Vector3(0, 3, 10);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            offset = new Vector3(0, 5, -7);
        }
    }

}
