using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    private Rigidbody player_rb;
    private Transform player_transform;
    [SerializeField] Camera cam;
    public float forwardForce = 200f;
    public float sidewaysForce = 50f;

    
    void Start()
    {
        player_rb = GetComponent<Rigidbody>();
        player_transform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        player_rb.AddForce(forwardForce * Time.deltaTime, 0,0);
        moveCamera();

        if (Input.GetKey("d"))
        {
            player_rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            player_rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }
    }

    private void moveCamera()
    {
        cam.transform.position = new Vector3(player_transform.position.x + 10, player_transform.position.y + 5, player_transform.position.z) ;
    }
}
