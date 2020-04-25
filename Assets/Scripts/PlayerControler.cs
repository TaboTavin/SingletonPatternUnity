using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    Vector3 movement;

    public Rigidbody playerRB;

   
    void Update()
    {
        if(GameManager.sharedInstance.currentGameState == GameState.inGame)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.z = Input.GetAxisRaw("Vertical");

            playerRB.MovePosition(playerRB.position + movement * Time.deltaTime);
        }
        
    }
}
