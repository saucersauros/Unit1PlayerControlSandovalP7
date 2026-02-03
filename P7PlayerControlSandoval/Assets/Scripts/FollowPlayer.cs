using UnityEngine;

public class FollowPlayer : MonoBehaviour
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
            camera.Set.Active(true);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            offset = new Vector3(0, 5, -7);
        }
    }

}
