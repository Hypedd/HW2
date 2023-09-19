using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed;
    public float basicSpeed;
    public float runningSpeed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible=false;
        Cursor.lockState=CursorLockMode.Locked;
        speed=basicSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            speed=runningSpeed;
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            speed=basicSpeed;
        }
    }
}
