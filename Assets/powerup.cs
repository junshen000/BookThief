using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public PowerupEffect PowerupEffect;
    private void OnTriggerEnter2D(Collider2D collision){
        
            Destroy(gameObject);
            PowerupEffect.Apply(collision.gameObject);
        
    }
}
