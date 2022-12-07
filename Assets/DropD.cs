using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropD : MonoBehaviour
{
    public Text txt;
    public Dropdown dd;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropTroca()
    {
        switch (dd.value)
        {

            case 0:
                txt.text = dd.captionText.text;
                break;
            case 1:
                txt.text = dd.captionText.text;
                break;
            case 2:
                txt.text = dd.captionText.text;
                break;
            case 3:
                txt.text = dd.captionText.text;
                break;
            case 4:
                txt.text = dd.captionText.text;
                break;

        }

    }


}
