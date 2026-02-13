using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 0, 0);
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
            offset = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            offset = new Vector3(0, 0, 0);
        }
    }

}
