using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Temporizador : MonoBehaviour
{

    public float tempo = 10.0f;
    public Text txt;
    public Image img;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(tempo > 0)
        {

            tempo -= Time.deltaTime;

        }
        else
        {
            tempo = 0;
        }

        txt.text = tempo.ToString("0");
        img.fillAmount = tempo/10;


    }
}
