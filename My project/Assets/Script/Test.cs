// using System.Diagnostics;
// using System.Transactions;
// using System.Threading.Tasks.Dataflow;
// using System.Diagnostics;
// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int playerSpeed;
    public int playerHealth;
    public Vector3 playerPosition;
    public Vector3 playerScale;

    
    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 1;
        playerHealth = 100;
        playerScale = new Vector3(2,3,2);
    }

    // Update is called once per frame
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
        playerHealth += 15;
        Debug.Log(playerHealth);
    }
}
