using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulo : MonoBehaviour
{
    public float forca = 500f;
    public Rigidbody2D bola;
    public bool liberaPulo = false;
    public int duplo = 2;
    public AudioClip puloSom;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(duplo > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                bola.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
                Gerenciador.inst.PlayAudio(puloSom);
                duplo--;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chão"))
        {
            duplo = 2;
          //  liberaPulo = true;
        }
    }

   /* private void OnCollisionExit2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chão"))
        {
            liberaPulo = false;
        }
    }*/

}
