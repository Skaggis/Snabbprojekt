using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KlotScript : MonoBehaviour
{
    public GameObject Player;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), Random.Range(-8, 8));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Time.deltaTime * movementSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
