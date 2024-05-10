using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl5 : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody rb;
    private float zBound = 6;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * speed * verticalInput);
        rb.AddForce(Vector3.right * speed * horizontalInput);

        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if(transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
