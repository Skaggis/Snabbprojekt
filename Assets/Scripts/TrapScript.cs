using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    //H�r deklarerar vi variabler och klasser
    //Skapa referens till �nskad spriterenderer
    //Skapa referens till �nskad boxcollider2D
    public SpriteRenderer WallSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        //Om "other" har namnet spelare
        if (other.gameObject.name == "Player")
        {
            //Aktivera f�llan
            //Steg 1: aktivera f�llans spriterenderer
            //Steg 2: aktivera f�llans box collider
        }
    }
}
