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

    // Start is called before the first frame update
    void Start()
    {
        // Gun
        Destroy(GunBullet, 2.5f);

        //Shotgun
        Destroy(ShotgunBullet, 2.5f);

        //Sword
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * gunSpeed * Time.deltaTime);
        transform.Translate(Vector3.up * shotgunSpeed * Time.deltaTime);

    }

    //vector2 reflect
    /*
    void OnCollisionEnter(Collision collision)
    {
        Vector2D inDirection = GetComponent<RigidBody2D>().velocity;
        Vector2D inNormal = collision.contacts[0].normal;
        Vector2D newVelocity = Vector2D.Reflect(inDirection, inNormal);
    }*/
}
