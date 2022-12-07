using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputFields : MonoBehaviour
{

    public Text txt, txt2;
    public InputField inputF;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Atualiza()
    {

        txt.text = inputF.text;


    }

    public void Atualiza2()
    {

        txt2.text = inputF.text;
        inputF.readOnly = true;


    }


}
