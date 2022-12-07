using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBars : MonoBehaviour
{

    public Scrollbar sb;
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScrollB()
    {
      
        if(sb.value == 0)
        {
            txt.text = "Zerooooo";
        }
        if (sb.value >= 1)
        {
            txt.text = "";
        }
    }

}
