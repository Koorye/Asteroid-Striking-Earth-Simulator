using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tmp : MonoBehaviour
{
    Text tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GameObject.Find("Canvas/Tmp").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = (GlobalVar.judge_time).ToString();
    }
}
