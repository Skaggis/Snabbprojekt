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
    Quaternion rotation = Quaternion.Euler(0, 0, 0);

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


        if (inputX > 0)
        {

            rotation = Quaternion.Euler(0, 0, -90);

        }

        else if (inputX < 0)
        {
            rotation = Quaternion.Euler(0, 0, 90);

        }

        else if (inputY > 0)
        {
            rotation = Quaternion.Euler(0, 0, 0);

        }
        else if (inputY < 0)
        {
            rotation = Quaternion.Euler(0, 0, -180f);


        }

        //riktning
        if (Input.GetKeyDown(KeyCode.Space)){

            Instantiate(GunBullet, transform.position, rotation);

        }

        if (Input.GetKeyDown(KeyCode.B))
        {

            Instantiate(ShotgunBullet, transform.position, rotation);

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PickUp")
        {
            //måste spawna inom banan!
            transform.position = new Vector3(Random.Range(-6, 8), Random.Range(-4, 4), 0);
            Destroy(other.gameObject);
        }

        //väggar, hål i marken, rullande klot
    }
}
