using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    bool flag;
    float force, distance, speed, collision_standard;
    public float max_speed;
    GameObject GravityCenter;
    // Start is called before the first frame update
    void Start()
    {
        collision_standard = 4f;
        max_speed = -1f;
        GravityCenter = GameObject.Find("GravityCenter");
    }

    void Update()
    {
        distance = (GravityCenter.transform.position - transform.position).magnitude;
        force = 10f / distance;
        GetComponent<Rigidbody>().AddForce(force*(GravityCenter.transform.position - transform.position));
        if (GlobalVar.judge_time > 0f)
        {
            speed = GetComponent<Rigidbody>().velocity.magnitude;
            if (speed > max_speed)
                max_speed = speed;
        }
        else if (GlobalVar.judge_time > -0.1f && flag == false)
        {
            if (max_speed > collision_standard)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
                GlobalVar.destroy_degree += 0.1f;
            }
            else if (max_speed > collision_standard / 1.3)
            {
                GetComponent<MeshRenderer>().material.color = Color.yellow;
                GlobalVar.destroy_degree += 0.075f;
            }
            else if (max_speed > collision_standard / 2)
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;
                GlobalVar.destroy_degree += 0.05f;
            }
            else if (max_speed > collision_standard / 4)
            {
                GetComponent<MeshRenderer>().material.color = Color.green;
                GlobalVar.destroy_degree += 0.025f;
            }
            else
            {
                GetComponent<MeshRenderer>().material.color = Color.white;
            }
            flag = true;
        }
        else if (GlobalVar.judge_time <= -0.1f && flag == true)
            flag = false;
    }
}
