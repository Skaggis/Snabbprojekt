using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

    private GameObject GunBullet;
    public float gunSpeed = 2;
    public int gunDmg = 1;

    private GameObject ShotgunBullet;
    public float shotgunSpeed = 2;
    public int shotgunDmg = 1;

    private GameObject Sword;
    public float swordSpeed = 1;
    public int swordDmg = 1;

    public GameObject vägg;

    // Start is called before the first frame update
    void Start()
    {
        // Gun
        Destroy(GunBullet, 2.5f);

        //Shotgun
        Destroy(ShotgunBullet, 2f);

        //Sword
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * gunSpeed * Time.deltaTime);
        transform.Translate(Vector3.up * shotgunSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Walls")
        {
            Destroy(gameObject);
        }
    }

}
