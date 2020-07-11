using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    GameObject ShootButtonObj,Bullet;
    Button ShootButton;
    void Start()
    {
        Bullet = GameObject.Find("Bullet");
        ShootButtonObj = GameObject.Find("Canvas/Shoot");
        ShootButton = ShootButtonObj.GetComponent<Button>();
        ShootButton.onClick.AddListener(onClick);
    }

    void onClick()
    {
        Instantiate(Bullet, new Vector3(0, 0, 50), new Quaternion(0, 0, 0, 0));
    }
}
