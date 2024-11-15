using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    //Här deklarerar vi variabler och klasser
    //Skapa referens till önskad spriterenderer
    //Skapa referens till önskad boxcollider2D
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
            //Aktivera fällan
            //Steg 1: aktivera fällans spriterenderer
            //Steg 2: aktivera fällans box collider
        }
    }
}
