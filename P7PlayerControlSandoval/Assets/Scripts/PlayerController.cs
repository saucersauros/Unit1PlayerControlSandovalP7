using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int speed = 20;
    public int turnspeed;
    public float horizontalInput;
    public float forwardInput;
    public int nitro;
    public int afterspeed;
    public GameObject particle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);
        if (Input.GetKey(KeyCode.Space))
        {
            speed = nitro;
            particle.SetActive(true);

        }
        else
        {
            speed = afterspeed;
            particle.SetActive(false);
        }
    }        //Move the vehicle forward
    
}