using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollider : MonoBehaviour
{
    public GameManger gameManger;
    private void OnTriggerEnter2D(Collider2D collision){
        
            if(collision.gameObject.tag=="Player"){
                gameManger.LoseGame();
            }
        
    }
}
