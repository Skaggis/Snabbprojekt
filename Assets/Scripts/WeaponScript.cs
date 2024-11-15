using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public float gunSpeed = 5;
    public int gunDmg = 1;

    public float shotgunSpeed = 4;
    public int shotgunDmg = 4;

    public float swordSpeed = 5;
    public int swordDmg = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Gun
        //Destroy(gameObject, 4f);

        //Shotgun
        //Destroy(gameObject, 2f);

        //Sword
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * gunSpeed * Time.deltaTime);

    }
}
