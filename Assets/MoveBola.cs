using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBola : MonoBehaviour
{
    public float vel = 2.5f;
    public SpriteRenderer boneco;
    public int moedas = 0;



    //UI

    public Text textCoin;
    public Image coin;
    public RawImage rImg;

    void Start()
    {
        coin.fillAmount = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {

        //Raw Image

        Rect temp = new Rect(rImg.uvRect);
        temp.x += 0.5f * Time.deltaTime;
        rImg.uvRect = temp;

        //fim


        boneco.flipX = false;
        
        

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(vel * Time.deltaTime, 0));
            
            boneco.flipX = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-vel * Time.deltaTime, 0));
            
            boneco.flipX = true;
            

        }
        
       
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Fire"))
        {
            
            moedas++;
            textCoin.text = moedas.ToString();
            Destroy(outro.gameObject);
        }
    }

}
