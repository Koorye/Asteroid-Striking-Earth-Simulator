using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reset : MonoBehaviour
{
    GameObject CubeController;
    Button reset;
    // Start is called before the first frame update
    void Start()
    {
        CubeController = GameObject.Find("CubeController");
        reset = GameObject.Find("Canvas/Reset").GetComponent<Button>();
        reset.onClick.AddListener(onClick);
    }

    void onClick()
    {
        foreach (Transform child in CubeController.transform)
        {
            child.GetComponent<MeshRenderer>().material.color = Color.white;
            child.GetComponent<Cube>().max_speed = -1f;
        }
        Bullet.flag = false;
        GlobalVar.destroy_degree = 0f;
    }
}
