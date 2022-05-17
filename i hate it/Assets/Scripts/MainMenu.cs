using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject ChooseLVL;
    public GameObject Menu;
    public GameObject Background;
    public GameObject Camera;
    float timer = 7.5f;
    float startVideo=0;
    bool flag = false;



    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& ChooseLVL.active==true)
        {

            chooseLVL();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (startVideo<Time.time&&flag==true)
        {
            Menu.SetActive(true);
            Background.SetActive(true);
            Camera.SetActive(false);
            flag = false;
        }
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene("Menu_scen");
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
       
    } 
    public void Video()
    {
        Menu.SetActive(false);
        Background.SetActive(false);
        Camera.SetActive(true);
        startVideo = Time.time+timer;
        flag = true;

    }
    public void chooseLVL()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
