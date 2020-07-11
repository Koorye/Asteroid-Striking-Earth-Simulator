using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static bool flag;
    float bullet_mass,force,distance;
    GameObject GravityCenter;
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        GravityCenter = GameObject.Find("GravityCenter");
    }

    // Update is called once per frame
    void Update()
    {
        bullet_mass = gameObject.GetComponent<Rigidbody>().mass;
        float scale = Mathf.Pow(bullet_mass,0.3f);
        transform.localScale = new Vector3(scale,scale,scale);
        distance = (GravityCenter.transform.position - transform.position).magnitude;
        force = bullet_mass*10f / distance;
        if (transform.position.x<1000)
            GetComponent<Rigidbody>().AddForce(force * (GravityCenter.transform.position - transform.position));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Finish") && flag==false)
        {
            GlobalVar.judge_time = 1.5f;
            Destroy(gameObject, 2);
            flag = true;
        }
    }
}
