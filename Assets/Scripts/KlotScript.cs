using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class KlotScript : MonoBehaviour
{
    public GameObject Player;

    public GameObject GunBullet;
    public GameObject ShotgunBullet;
    public float movementSpeed;
    public Transform spawnPoint;
    public int klotCounter;


    // Start is called before the first frame update
    void Start()
    {
        //
        spawnPoint = GameObject.Find("SpawnKlot").transform;
        transform.position = spawnPoint.position;
        Player = GameObject.Find("Player");
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Time.deltaTime * movementSpeed);
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            Player.SetActive(false);

        }

        else if (other.tag == "GunBullet" || other.tag == "ShotgunBullet")
        {
            
            GameObject.Find("KlotSpawner").GetComponent<KlotSpawnerScript>().klotCounter--;
            Debug.Log(klotCounter);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }


}
