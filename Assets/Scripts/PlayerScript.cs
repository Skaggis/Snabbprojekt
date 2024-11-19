using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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


        //roterar spelaren? �t vilket h�ll skjuts?
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(GunBullet, transform.position, Quaternion.identity);

        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(ShotgunBullet, transform.position, Quaternion.identity);

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PickUp")
        {
            transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), 0);
            Destroy(other.gameObject);
        }

        //v�ggar, h�l i marken, rullande klot
    }
}
