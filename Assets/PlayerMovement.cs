using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float Xmin, Xmax;
    public float Zmin, Zmax;
    public float speed;
    public float tilt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveH, 0.0f, moveV);
        rb.velocity = movement*speed;


        //control position
        float constrainX = Mathf.Clamp(rb.position.x,Xmin,Xmax);
        float constrainZ = Mathf.Clamp(rb.position.z,Zmin,Zmax);

        rb.position = new Vector3(constrainX, 0.0f, constrainZ);

        //Control Rotation
        rb.rotation = Quaternion.Euler(0.0f, 0.0f,rb.velocity.x);

    }
}
