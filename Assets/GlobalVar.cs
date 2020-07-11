using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVar : MonoBehaviour
{
    Text DestroyDegree;
    public static float bullet_mass, judge_time, destroy_degree;
    GameObject Bullet,BulletMassObj;
    InputField BulletMass;
    // Start is called before the first frame update
    void Start()
    {
        destroy_degree = 0f;
        judge_time = -100f;
        Bullet = GameObject.Find("Bullet");
        BulletMassObj = GameObject.Find("Canvas/BulletMass");
        BulletMass = BulletMassObj.GetComponent<InputField>();
        DestroyDegree = GameObject.Find("Canvas/DestroyDegree").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyDegree.text = "破坏程度: " + destroy_degree.ToString()+"%";
        judge_time -= Time.deltaTime;
        Bullet.GetComponent<Rigidbody>().mass = float.Parse(BulletMass.text);
    }
}
