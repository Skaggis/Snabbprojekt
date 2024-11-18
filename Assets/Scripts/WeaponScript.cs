using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public GameObject Player;

    public GameObject GunBullet;
    public float gunSpeed = 5;
    public int gunDmg = 1;

    public GameObject ShotgunBullet;
    public float shotgunSpeed = 4;
    public int shotgunDmg = 4;

    public GameObject Sword;
    public float swordSpeed = 5;
    public int swordDmg = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Gun
        Destroy(GunBullet, 4f);

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
}
