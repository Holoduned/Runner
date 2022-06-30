using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public Canvas pauseMenu;
    public GameObject startMenu;

    //public PlayerMove player;
    private float currentSpeed;
    void Start()
    {
        Time.timeScale = 0f;
        //player.speed = 0f;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && !startMenu.activeSelf)
        {
            if (!pauseMenu.enabled)
            {
                //currentSpeed = player.speed;
                //player.speed = 0f;
                pauseMenu.enabled = true;
                Time.timeScale = 0f;
            }
        }
        
    }

    public void startLevel()
    {
        Time.timeScale = 1f;
        //player.speed = 0.1f;
        startMenu.SetActive(false);
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Continue()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1f;
        //player.speed = currentSpeed;
    }
    
    
    
}
