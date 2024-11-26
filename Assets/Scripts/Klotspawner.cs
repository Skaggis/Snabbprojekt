using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KlotSpawnerScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Klot;
    public GameObject GunBullet;
    public GameObject ShotgunBullet;
    public float movementSpeed;
    public int klotCounter;

    // Start is called before the first frame update
    void Start()
    {

            StartCoroutine(KlotSpawner());
        Player = GameObject.Find("Player");


        //transform.position = spawnPoint.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Time.deltaTime * movementSpeed);
        }

    }

    IEnumerator KlotSpawner()
    {
        while (true)
        {

            if (klotCounter < 3 && GameObject.FindWithTag("Player") != null)

            {
                Instantiate(Klot, new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0), Quaternion.identity);
                klotCounter++;
                Debug.Log(klotCounter);
                yield return new WaitForSeconds(3);
            }

            yield return null;
        }
    }


}
