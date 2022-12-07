using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatilho : MonoBehaviour
{
    public float velArma;
    public bool liberaRot;
    public GameObject arma;
    // Start is called before the first frame update
    void Start()
    {
        liberaRot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (liberaRot == true)
        {
            arma.gameObject.transform.Rotate(new Vector3(0, 0, velArma * Time.deltaTime));
        }
    }
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("bola"))
        {
            liberaRot = true;
        }
    }
    private void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("bola"))
        {
            liberaRot = false;
        }
    }

}
