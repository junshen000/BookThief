using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{
    public GameObject GameOverMenu;
    public GameObject LoseMenu;
    public float restartDelay = 1f;
    public void EndGame(){
        GameOverMenu.SetActive(true);
          }
    public void LoseGame(){
        LoseMenu.SetActive(true);
        
    }
    
}
