using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class CubeController : MonoBehaviour
{
    GameObject Cube;
    int time;
    float x, y, z, r;
    // Start is called before the first frame update
    void Start()
    {
        Cube = GameObject.Find("Cube");
        time = 1000;
        r = 20;
        for (int i = 0; i < time; ++i)
        {
            x = Random.Range(-r, r);
            y = Random.Range(-Mathf.Sqrt(r * r - x * x), Mathf.Sqrt(r * r - x * x));
            if (Random.Range(0, 100) < 50)
                z = Mathf.Sqrt(r * r - x * x - y * y);
            else
                z = -Mathf.Sqrt(r * r - x * x - y * y);
            Instantiate(Cube, new Vector3(x, y, z), new Quaternion(0, 0, 0, 0), this.transform);
        }
    }
}
