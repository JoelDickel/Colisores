using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTN : MonoBehaviour
{

    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EventoBtn()
    {

        Instantiate(coin, new Vector2(0, 0), Quaternion.identity);

    }



}
