using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.Windows;

public class PlayerScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Teleport;
    public GameObject GunBullet;
    public GameObject ShotgunBullet;
    public int movementSpeed;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnPoint.position;
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime);
        transform.Translate(Vector3.up * movementSpeed * inputY * Time.deltaTime);


        //riktning???
        if (Input.GetKeyDown(KeyCode.Space)){

            Quaternion rotation = Quaternion.Euler(0, 0, 0);

            //höger/vänster är inverterade
            if (inputX > 0){

                rotation = Quaternion.Euler(0, 0, 90);
                Instantiate(GunBullet, transform.position, Quaternion.Euler(0, 0, -90f));
                

            }
            if (inputX < 0){
                rotation = Quaternion.Euler(0, 0, -90);
                Instantiate(GunBullet, transform.position, Quaternion.Euler(0, 0, 90));
               

            }
            
            if (inputY > 0){
                rotation = Quaternion.Euler(0, 0, 180f);
                Instantiate(GunBullet, transform.position, Quaternion.Euler(0, 0, 0));

            }
            if (inputY < 0){
                rotation = Quaternion.Euler(0, 0, -180f);
                Instantiate(GunBullet, transform.position, Quaternion.Euler(0, 0, -180f));

            }


        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Quaternion rotation = Quaternion.Euler(0, 0, 0);

            //höger/vänster är inverterade
            if (inputX > 0)
            {

                rotation = Quaternion.Euler(0, 0, 90);
                Instantiate(ShotgunBullet, transform.position, Quaternion.Euler(0, 0, -90f));


            }
            if (inputX < 0)
            {
                rotation = Quaternion.Euler(0, 0, -90);
                Instantiate(ShotgunBullet, transform.position, Quaternion.Euler(0, 0, 90));


            }

            if (inputY > 0)
            {
                rotation = Quaternion.Euler(0, 0, 180f);
                Instantiate(ShotgunBullet, transform.position, Quaternion.Euler(0, 0, 0));

            }
            if (inputY < 0)
            {
                rotation = Quaternion.Euler(0, 0, -180f);
                Instantiate(ShotgunBullet, transform.position, Quaternion.Euler(0, 0, -180f));

            }

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PickUp")
        {
            //måste spawna inom banan!
            transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), 0);
            Destroy(other.gameObject);
        }

        //väggar, hål i marken, rullande klot
    }
}
