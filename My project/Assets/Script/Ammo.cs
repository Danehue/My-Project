// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public int ammoSpeed;
    public Vector3 ammoPosition;
    public int ammoDamage;

    void Start()
    {
        ammoSpeed = 1;
        ammoDamage = 100;
        ammoPosition = new Vector3(3,0,0);
        
    }

    void Update()
    {
        transform.position += ((ammoPosition * Time.deltaTime ) * ammoSpeed);
    }
}
