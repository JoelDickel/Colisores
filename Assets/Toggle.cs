using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{


    public Text txt;
    public Toggle tg;
    // Start is called before the first frame update
    void Start()
    {
        tg = GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggles()
    {
        txt.text = tg.GetComponentInChildren<Text>().text;
    }

}
