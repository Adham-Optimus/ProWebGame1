using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{
    public float speed;
    public Transform transform;
    Rigidbody rb;
    [SerializeField] private FixedJoystick fj;
    
    
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        /*Vector3 newPos = transform.position;
        newPos += new Vector3(speed * Time.deltaTime * x, 
                              0, 
                              speed * Time.deltaTime * z);
        rb.MovePosition(newPos);*/

        rb.velocity = new Vector3(fj.Horizontal * speed,
                                  rb.velocity.y,
                                  fj.Vertical * speed);
    }
}
