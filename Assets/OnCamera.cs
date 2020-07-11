using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCamera : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, -speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.RotateAround(new Vector3(0, 0, 0), Vector3.right, -speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.RotateAround(new Vector3(0, 0, 0), Vector3.right, speed * Time.deltaTime);
    }
}
