// using System.Diagnostics;
// using System.Transactions;
// using System.Threading.Tasks.Dataflow;
// using System.Diagnostics;
// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // public int playerSpeed;
    // public int playerHealth;
    // public Vector3 playerPosition;
    // public Vector3 playerScale;

    public GameObject ammo;
    public Transform ammoInitialPosition;

    
    void Start()
    {
        // playerSpeed = 1;
        // playerHealth = 100;
        // playerScale = new Vector3(2,3,2);

        handleShoot();

    }

    void handleShoot()
    {
        Instantiate(ammo,ammoInitialPosition.position,ammoInitialPosition.rotation);
    }
    
/*
    void Update()
    {
        handleMove();
    }  

    void handleMove()
    {
        transform.localScale = playerScale;
        transform.position += ((playerPosition * Time.deltaTime ) * playerSpeed);
    }

    void damagePlayer()
    {
        playerHealth -= 20;
        Debug.Log(playerHealth);
    }

    void healPlayer()
    {
        playerHealth += 20;
        Debug.Log(playerHealth);
    }
*/ 
    
}
