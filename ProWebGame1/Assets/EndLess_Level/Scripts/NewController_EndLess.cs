using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewController_EndLess : MonoBehaviour
{
    [SerializeField] private VariableJoystick fj;
    public float speed;
    Transform transform;
    Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        /*float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 newPos = transform.position;
        newPos += new Vector3(speed * Time.deltaTime * x, 0, speed * Time.deltaTime * z);
        rb.MovePosition(newPos);*/

        rb.velocity = new Vector3(fj.Horizontal * speed,
                                  rb.velocity.y,
                                  rb.velocity.z);
    }

    
}
